using Museo_pictorico_ppai.DataBase;
using Museo_pictorico_ppai.Entidades;
using Museo_pictorico_ppai.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Museo_pictorico_ppai.Pantallas;

namespace Museo_pictorico_ppai.Repositorios
{
    public class GestorVentaEntradas // clase del gestor de pantallas
    {
        
        private Sesion sesionActual;
        private Sede sedeActual;
        private Empleado empleadoLogueado;
        private PantallaVentaEntradas pantallaVentaEntradas;
        private int cantidadEntradas;
        private int duracion;
        private Tarifa tarifaSelec;
        private List<Entrada> entradas;
        private bool conGuia;
        private int ultNumEntrada;

        private AccesoBD _BD;

        public GestorVentaEntradas(Sesion sesion, PantallaVentaEntradas pantallaVenta)
        {
            sesionActual = sesion; //recibe la sesion actual
            _BD = new AccesoBD(); // instancia la clase acceso a base de datos 
            pantallaVentaEntradas = pantallaVenta; 
        }
        public GestorVentaEntradas() { }

        public void opcionVtaEntrada() // Gestor empieza a ejecutar el método opcionVtaEntrada
        {
            buscarEmpleadoLogueado();
            buscarSede();
            buscarTarifasDeSede();
        }
        public void buscarEmpleadoLogueado()  // Busca el empleado logueado para la sesión actual
        {
            empleadoLogueado = sesionActual.getEmpleadoEnSesion();
            buscarSede();
        }

        public void buscarSede() 
        {
            sedeActual = empleadoLogueado.obtenerSede(); //Obtiene la sede actual a traves del empleado logueado
             
        }
     

        public void tomarTarifasSeleccionadas(Tarifa tarifasSeleccionadas, bool guia) // obtiene la tarifa seleccionada 
        {
            tarifaSelec = tarifasSeleccionadas;
            conGuia = guia;
            buscarExposicionVigente();
            pantallaVentaEntradas.solicitarCantidadEntradas();
        }
       

        public int calcularTotalaPagar() // funcion  para calcular monto segun la tarifa seleccionada
        {
            int total = cantidadEntradas * tarifaSelec.montoTarifa;
            if (conGuia)
                total += 50;
            return total;
        }

        public void buscarTarifasDeSede()  // obtiene un objeto del tipo DataTable con los datos de las tarifas
        {
            DataTable tablaTarifas = new DataTable();
            tablaTarifas = sedeActual.obtenerTarifasVigentes(sedeActual.idSede);
            
            pantallaVentaEntradas.mostrarTarifasVigentes(tablaTarifas);
        }

        public bool ResetearVisitantes(int sede) // funcion para volver a 0 la cantidad de visitantes
        {
            string sqltxt = $"UPDATE [dbo].[visitantes] SET nroVisitantes = 0 " +
                $" WHERE sede = {sede}";

            return _BD.EjecutarSQL(sqltxt);

        }

        public void buscarExposicionVigente() // obtiene la duracion de las exposiciones vigentes
        {
            duracion = sedeActual.calcularDuracionDeExposicionesVigentes();
        }
        public void tomarCantidadEntradas(int cantEntrada) // toma la cantidad de entradas ingresadas y obtiene el monto total y la ocupación
        {
            cantidadEntradas = cantEntrada;
            long capacidadMax = buscarCapacidadMax();
            DateTime fechaActual = ObtenerFechaActual();
            long ocupacion = calcularCantidadVisitantes(fechaActual);
            validarCantidadVisitantes(capacidadMax, ocupacion);
            int montoTotal = calcularTotalaPagar();
            pantallaVentaEntradas.mostrarDetalleVenta(cantidadEntradas, tarifaSelec.montoTarifa, montoTotal);
            pantallaVentaEntradas.solicitarConfirmacion();
        }
        public long buscarCapacidadMax() // busca la capacidad máxima de la sede actual
        {
            long capacidadMaxima = sedeActual.cantidadMaximaVisitantesSede;
            return capacidadMaxima;

        }
        public DateTime ObtenerFechaActual() // fecha al instante
        {
            DateTime fecha = DateTime.Now;
            return fecha;
        }
        public long calcularCantidadVisitantes(DateTime fecha) // devuelve el numero actual de ocupacion
        {
            long ocup = sedeActual.calcularOcupacion(fecha);
            return ocup;
        }
        public void validarCantidadVisitantes(long capacidadMax, long ocupacion) // valida que no se supere el cupo máximo
        {
            if (ocupacion + cantidadEntradas > capacidadMax)
            {
                throw new ApplicationException("La capacidad de la sede seria superada con la venta de entradas");
            }
        }

        public void tomarConfirmacionVenta() // toma confirmacion de venta de entrada
        {
            
            ultNumEntrada = buscarUltimoNroEntrada();

            generarEntradas();
            
            actVisitantesEnPantallas();
        }

        public int buscarUltimoNroEntrada() //recorre las entradas y busca el nro de la última
        {
            return Entrada.getNroEntrada();
        }

        public void generarEntradas() // genera las n entradas y las inserta en la bd
        {
            entradas = new List<Entrada>();
            for (int i = 0; i < cantidadEntradas; i++)
            {

                Entrada newEnt = new Entrada()
                {
                    nroEntrada = buscarUltimoNroEntrada() + 1+i,
                    fechaHoraVenta = ObtenerFechaActual(),
                    monto = tarifaSelec.montoTarifa,
                    tarifa = tarifaSelec.idTarifa,
                    idSede = sedeActual.idSede
                };
                entradas.Add(newEnt);
                imprimirEntrada(newEnt);
            }
            Entrada.guardarEnBD(entradas);

        }
        public void actVisitantesEnPantallas() // método actualizar la cantidad de visitantes en la pantalla de la sala 
        {
            PantallaSala _ps = new PantallaSala();
            _ps.actualizarCantVisitantes();
        }
        public void imprimirEntrada(Entrada entrada) // funcion que llama al sw de impresion 
        {
            SoftwareDeImpresion si = new SoftwareDeImpresion();
            si.imprimir(entrada);
                       
        }
    }
}
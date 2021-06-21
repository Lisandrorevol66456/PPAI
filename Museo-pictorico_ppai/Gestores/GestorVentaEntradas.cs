using Museo_pictorico_ppai.DataBase;
using Museo_pictorico_ppai.Entidades;
using Museo_pictorico_ppai.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Repositorios
{
    public class GestorVentaEntradas // clase del gestor de pantallas
    {
        private List<Entrada> entradas;
        private Sesion sesionActual;
        private int tarifas;
        private AccesoBD _BD;
        private Sede sedeActual;
        private int cantidadEntradas;
        private Empleado empleadoLogueado;
        private PantallaVentaEntradas pantallaVentaEntradas;
        
        

        public GestorVentaEntradas(Sesion sesion, PantallaVentaEntradas pantallaVenta)
        {
            sesionActual = sesion; //recibe la sesion actual
            _BD = new AccesoBD(); // instancia la clase acceso a base de datos 
            pantallaVentaEntradas = pantallaVenta; 
        }
        public GestorVentaEntradas() { }

        public void opcionVtaEntrada()
        {
            buscarEmpleadoLogueado();
            buscarSede();
            buscarTarifasDeSede();
        }
        public void buscarEmpleadoLogueado()
        {
            empleadoLogueado = sesionActual.getEmpleadoEnSesion();
            buscarSede();
        }

        public void buscarSede() 
        {
            sedeActual = empleadoLogueado.obtenerSede(); //Obtiene la sede actual a traves del empleado logueado
             
        }
     

        public void tomarTarifasSeleccionadas(int tarifasSeleccionadas)
        {
            tarifas = (tarifasSeleccionadas);
        }
        public Entrada CrearEntrada() // crea una nueva instancia de la clase Entrada
        {
            Entrada entrada = new Entrada();
            return entrada;
        }
        public float CalcularTotalaPagar(int tarifa,bool guia) // funcion  para calcular monto segun la tarifa seleccionada
        {
            float monto = 0;
            
            if (tarifa == 1)
                monto = 300;
            if (tarifa == 2)
                monto = 200;
            if (tarifa == 3)
                monto = 200;
            if (tarifa == 4)
                monto = 200;
            if (tarifa == 5)
                monto = 150;
            if (tarifa == 6)
                monto = 100;
            if (tarifa == 7)
                monto = 100;
            if (tarifa == 8)
                monto = 100;
             if(guia)
            {
                return monto + 50;
            }         
            return monto;
        }

        public DataTable ObtenerTiposEntradas() // obtiene un objeto del tipo DataTable con los datos de los tipos de entrada
        {
            string sqlTxt = $"SELECT * FROM tipoEntrada ";
            var TiposDTRows = _BD.Consulta(sqlTxt);
            return TiposDTRows;
        }

        public DataTable ObtenerTiposVisita() // obtiene un objeto del tipo DataTable con los datos de los tipos de visita
        {
            string sqlTxt = $"SELECT * FROM TipoVisita ";
            var TiposVisitaDTRows = _BD.Consulta(sqlTxt);
            return TiposVisitaDTRows;
        }

        public void buscarTarifasDeSede()  // obtiene un objeto del tipo DataTable con los datos de las tarifas
        {
            DataTable tablaTarifas = new DataTable();
            tablaTarifas = sedeActual.obtenerTarifasVigentes(); //CAMBIAR, AGREGAR PARAMETRO
            pantallaVentaEntradas.mostrarTarifasVigentes(tablaTarifas);
        }
        public bool Guardar(Entrada entrada) // funcion para guardar la entrada, la ingresa dentro de la BD
        {
         
            string sqlTxt = $"INSERT [dbo].[Entradas] ([fechaHoraVenta], [monto],[tarifa], [sede])" +
                $" VALUES('{DateTime.Now.ToString("yyyy-MM-dd HH:mm")}', '{entrada.monto}','{entrada.tarifa}', '{entrada.idSede}')";
            
            return _BD.EjecutarSQL(sqlTxt);
        }
        public bool ActualizarVisitantes(int cantvisita, int sede) // actualiza la cantidad de visitantes
        {
            string sqltxt = $"UPDATE [dbo].[visitantes] SET nroVisitantes = nroVisitantes+{cantvisita} " +
                $" WHERE sede = {sede}";

            return _BD.EjecutarSQL(sqltxt);
           // _sede.CalcularVisitantes(cantvisita);
          
        }
        public bool ResetearVisitantes(int sede) // funcion para volver a 0 la cantidad de visitantes
        {
            string sqltxt = $"UPDATE [dbo].[visitantes] SET nroVisitantes = 0 " +
                $" WHERE sede = {sede}";

            return _BD.EjecutarSQL(sqltxt);

        }
        public DataTable MostrarVisitantes(int sede) //  // obtiene un objeto del tipo DataTable con la cantidad de visitantes
        {
            string sqlTxt = $"SELECT distinct visitantes.nroVisitantes FROM visitantes where sede = {sede}";
            var visitantesDTRows = _BD.Consulta(sqlTxt);
            return visitantesDTRows;

        }
        public int buscarExposicionVigente()
        {
            int duracion = sedeActual.calcularDuracionDeExposicionesVigentes();
            return duracion;
        }
        public void tomarCantidadEntradas(int cantEntrada)
        {
            this.cantidadEntradas += cantEntrada;
                       
        }
        public long BuscarCapacidadMax()
        {
            long capacidadMaxima = sedeActual.cantidadMaximaVisitantesSede;
            return capacidadMaxima;

        }
        public DateTime ObtenerFechaActual()
        {
            DateTime fecha = DateTime.Now;
            return fecha;
        }
        public long CalcularCantidadVisitantes()
        {
            DateTime FechaActual = this.ObtenerFechaActual();
            long visit = sedeActual.CalcularOcupacion(FechaActual) + cantidadEntradas;
            return visit;
        }
        public bool ValidarCantidadVisitantes()
        {
            DateTime FechaActual = this.ObtenerFechaActual();
          if(this.BuscarCapacidadMax() - sedeActual.CalcularOcupacion(FechaActual)- cantidadEntradas >= 0)
            {
                return true;
            }return false;
        }
     
    }
}
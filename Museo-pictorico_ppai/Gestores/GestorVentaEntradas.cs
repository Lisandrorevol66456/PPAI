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
     

        public void tomarTarifasSeleccionadas(Tarifa tarifasSeleccionadas, bool guia)
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

        public void buscarExposicionVigente()
        {
            duracion = sedeActual.calcularDuracionDeExposicionesVigentes();
        }
        public void tomarCantidadEntradas(int cantEntrada)
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
        public long buscarCapacidadMax()
        {
            long capacidadMaxima = sedeActual.cantidadMaximaVisitantesSede;
            return capacidadMaxima;

        }
        public DateTime ObtenerFechaActual()
        {
            DateTime fecha = DateTime.Now;
            return fecha;
        }
        public long calcularCantidadVisitantes(DateTime fecha)
        {
            long ocup = sedeActual.calcularOcupacion(fecha);
            return ocup;
        }
        public void validarCantidadVisitantes(long capacidadMax, long ocupacion)
        {
            if (ocupacion + cantidadEntradas > capacidadMax)
            {
                throw new ApplicationException("La capacidad de la sede seria superada con la venta de entradas");
            }
        }

        public void tomarConfirmacionVenta()
        {
            
            ultNumEntrada = buscarUltimoNroEntrada();

            generarEntradas();
            //imprimirEntradas() sin programar
            actVisitantesEnPantallas();
        }

        public int buscarUltimoNroEntrada() 
        {
            return Entrada.ultimoNumero();
        }

        public void generarEntradas()
        {
            entradas = new List<Entrada>();
            for (int i = 0; i < cantidadEntradas; i++)
            {
                Entrada newEnt = new Entrada()
                {
                    fechaHoraVenta = ObtenerFechaActual(),
                    monto = tarifaSelec.montoTarifa,
                    tarifa = tarifaSelec.idTarifa,
                    idSede = sedeActual.idSede
                };
                entradas.Add(newEnt);
                imprimirEntrada(newEnt,cantidadEntradas);
            }
            Entrada.guardarEnBD(entradas);

        }
        public void actVisitantesEnPantallas()
        {
            PantallaSala _ps = new PantallaSala();
            _ps.actualizarCantVisitantes();
        }
        public void imprimirEntrada(Entrada entrada, int cantEntradas)
        {
            FileStream fs = new FileStream(@"C:\Users\Windows 10\Desktop\Entradas impresas\Entradas.pdf", FileMode.Create);
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7);
            PdfWriter pw = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            doc.AddAuthor("Museo");
            doc.AddTitle("Entrada");

            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 11, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            doc.Add(new Paragraph("Entrada a Museo"));
            doc.Add(Chunk.NEWLINE);
            PdfPTable tblEntrada = new PdfPTable(5);
            tblEntrada.WidthPercentage = 100;

            PdfPCell clIdEntrada = new PdfPCell(new Phrase("Numero de entrada", standarFont));
            clIdEntrada.BorderWidth = 0;
            clIdEntrada.BorderWidthBottom = 0.75f;

            PdfPCell clFechahora = new PdfPCell(new Phrase("Fecha y hora", standarFont));
            clFechahora.BorderWidth = 0;
            clFechahora.BorderWidthBottom = 0.75f;

            PdfPCell clMonto = new PdfPCell(new Phrase("Monto", standarFont));
            clMonto.BorderWidth = 0;
            clMonto.BorderWidthBottom = 0.75f;

            PdfPCell clTarifa = new PdfPCell(new Phrase("Numero de tarifa", standarFont));
            clTarifa.BorderWidth = 0;
            clTarifa.BorderWidthBottom = 0.75f;

            PdfPCell ClSede = new PdfPCell(new Phrase("Numero de Sede", standarFont));
            clIdEntrada.BorderWidth = 0;
            clIdEntrada.BorderWidthBottom = 0.75f;

            tblEntrada.AddCell(clIdEntrada);
            tblEntrada.AddCell(clFechahora);
            tblEntrada.AddCell(clMonto);
            tblEntrada.AddCell(clTarifa);
            tblEntrada.AddCell(ClSede);
            if (entrada != null)
            {
                clIdEntrada = new PdfPCell(new Phrase(entrada.nroEntrada.ToString()));
                clIdEntrada.BorderWidth = 0;
                clFechahora = new PdfPCell(new Phrase(entrada.fechaHoraVenta.ToString()));
                clFechahora.BorderWidth = 0;
                clMonto = new PdfPCell(new Phrase(entrada.monto.ToString()));
                clMonto.BorderWidth = 0;
                clTarifa = new PdfPCell(new Phrase(entrada.tarifa.ToString()));
                clTarifa.BorderWidth = 0;
                ClSede = new PdfPCell(new Phrase(entrada.idSede.ToString()));
                ClSede.BorderWidth = 0;

                tblEntrada.AddCell(clIdEntrada);
                tblEntrada.AddCell(clFechahora);
                tblEntrada.AddCell(clMonto);
                tblEntrada.AddCell(clTarifa);
                tblEntrada.AddCell(ClSede);

            }doc.Add(tblEntrada);
            doc.Close();
            pw.Close();
            
                       
        }
    }
}
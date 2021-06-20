using Museo_pictorico_ppai.DataBase;
using Museo_pictorico_ppai.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Repositorios
{
    public class GestorPantallaEntrada // clase del gestor de pantallas
    {
        //private Form1 _pantallaEntrada;
        private AccesoBD _BD;
        //private Sede _sede;
        //private int visitantes = 0;
     

        public GestorPantallaEntrada()
        {
            _BD = new AccesoBD(); // instancia la clase acceso a base de datos 
           // _sede = new Sede();
            //_pantallaEntrada = new Form1();
        }
        public void BuscarEmpleadoLogueado()
        {

        }
        public void ConocerUsuario()
        {

        }
        public DataTable ObtnerSede(int sede) // obtiene un objeto del tipo DataTable con los datos de la sede
        {
            string sqlTxt = $"SELECT * from Sede WHERE id =" +sede;
            var SedeDTRows = _BD.Consulta(sqlTxt);
            return SedeDTRows;
        }
        public void MostrarDetalleVenta()
        {

        }
        //public int TomarSeleccionTarifa()
        //{
        //    _
        //}
        public Entrada CrearEntrada() // crea una nueva instancia de la clase Entrada
        {
            Entrada entrada = new Entrada();
            return entrada;
        }
        public float CalcularMonto(int tarifa) // funcion  para calcular monto segun la tarifa seleccionada
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
                       
            return monto;
        }

        public DataTable ObtenerTiposEntradas() // obtiene un objeto del tipo DataTable con los datos de los tipos de entrada
        {
            string sqlTxt = $"SELECT * FROM tipoEntrada ";
            var TiposDTRows = _BD.Consulta(sqlTxt);
            return TiposDTRows;
        }
        public DataTable ObtenerEntradas() // obtiene un objeto del tipo DataTable con los datos de las entradas
        {
            string sqlTxt = $"SELECT * from Entradas";
            var entradasDTRows = _BD.Consulta(sqlTxt);
            return entradasDTRows;

        }
        public DataTable ObtenerTiposVisita() // obtiene un objeto del tipo DataTable con los datos de los tipos de visita
        {
            string sqlTxt = $"SELECT * FROM TipoVisita ";
            var TiposVisitaDTRows = _BD.Consulta(sqlTxt);
            return TiposVisitaDTRows;
        }

         public DataTable BuscarTarifas()  // obtiene un objeto del tipo DataTable con los datos de las tarifas
        {
            string sqlTxt = $"select t.id,tv.nombre as 'tipo visita',te.nombre as'tipo entrada',t.precio from tarifas t join tipoEntrada te on t.tipoEntrada = te.idTipo join TipoVisita tv on t.tipoVisita = tv.id order by tv.nombre; ";
            var tarifasDTRows = _BD.Consulta(sqlTxt);
            return tarifasDTRows;

        }
        public bool Guardar(Entrada entrada) // funcion para guardar la entrada, la ingresa dentro de la BD
        {
         
            string sqlTxt = $"INSERT [dbo].[Entradas] ([fechaHoraVenta], [monto],[tarifa], [sede])" +
                $" VALUES('{DateTime.Now.ToString("yyyy-MM-dd")}', '{entrada.monto}','{entrada.tarifa}', '{entrada.idSede}')";
            
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
        public float CalcularDuracionResumidaObras() // funcion para calcular la duracion de la obra
        {
             var duracion = 0;
            return duracion;

        }
    }
}
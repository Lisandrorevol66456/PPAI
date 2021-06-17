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
    public class GestorPantallaEntrada
    {
        //private Form1 _pantallaEntrada;
        private AccesoBD _BD;
        private Sede _sede;
        //private int visitantes = 0;
     

        public GestorPantallaEntrada()
        {
            _BD = new AccesoBD();
            _sede = new Sede();
            //_pantallaEntrada = new Form1();
        }
        public void BuscarEmpleadoLogueado()
        {

        }
        public void ConocerUsuario()
        {

        }
        public DataTable ObtnerSede(int sede)
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

        //}
        public Entrada CrearEntrada()
        {
            Entrada entrada = new Entrada();
            return entrada;
        }
        public float calcularMonto(int tarifa)
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

        public DataTable ObtenerTiposEntradas()
        {
            string sqlTxt = $"SELECT * FROM tipoEntrada ";
            var TiposDTRows = _BD.Consulta(sqlTxt);
            return TiposDTRows;
        }
        public DataTable ObtenerEntradas()
        {
            string sqlTxt = $"SELECT * from Entradas";
            var entradasDTRows = _BD.Consulta(sqlTxt);
            return entradasDTRows;

        }
        public DataTable ObtenerTiposVisita()
        {
            string sqlTxt = $"SELECT * FROM TipoVisita ";
            var TiposVisitaDTRows = _BD.Consulta(sqlTxt);
            return TiposVisitaDTRows;
        }

         public DataTable BuscarTarifas()
        {
            string sqlTxt = $"select t.id,tv.nombre as 'tipo visita',te.nombre as'tipo entrada',t.precio from tarifas t join tipoEntrada te on t.tipoEntrada = te.idTipo join TipoVisita tv on t.tipoVisita = tv.id order by tv.nombre; ";
            var tarifasDTRows = _BD.Consulta(sqlTxt);
            return tarifasDTRows;

        }
        public bool Guardar(Entrada entrada)
        {
         
            string sqlTxt = $"INSERT [dbo].[Entradas] ([fechaHoraVenta], [monto],[tarifa], [sede])" +
                $" VALUES('{DateTime.Now.ToString("yyyy-MM-dd")}', '{entrada.monto}','{entrada.tarifa}', '{entrada.idSede}')";
            
            return _BD.EjecutarSQL(sqlTxt);
        }
        public void ActualizarVisitantes(int cantvisita)
        {
           _sede.CalcularVisitantes(cantvisita);
          
        }
        public long MostrarVisitantes()
        {
            return _sede.visitantes;

        }
    }
}
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
    public class EntradaRepositorio
    {
        //private Form1 _pantallaEntrada;
        private AccesoBD _BD;

        public EntradaRepositorio()
        {
            _BD = new AccesoBD();
            //_pantallaEntrada = new Form1();
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

         public DataTable ObtenerTarifas()
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
    }
}
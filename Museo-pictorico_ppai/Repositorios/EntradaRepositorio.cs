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

        private AccesoBD _BD;

        public EntradaRepositorio()
        {
            _BD = new AccesoBD();
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
        //public bool guardar(Entrada entrada)
        //{
        //    string sqlTxt = $"INSERT [dbo].[Entradas] ([sede], [nombre], [apellido], " +
        //        $"[domicilio], [fecha_Inicio],[fecha_cal],[cod_calificacion])" +
        //        $"VALUES ('{entrada.cuit_Empresa}', '{entrada.nombre}', '{entrada.apellido}', '{entrada.domicilio}' , '{empresa.cod_calificacion}')";

        //    return _BD.EjecutarSQL(sqlTxt);
        //}
    }
}
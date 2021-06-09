using Museo_pictorico_ppai.DataBase;
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
    }
}
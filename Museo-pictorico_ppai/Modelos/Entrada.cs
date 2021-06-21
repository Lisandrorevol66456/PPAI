using Museo_pictorico_ppai.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Modelos
{
    public class Entrada
    {
        AccesoBD _BD = new AccesoBD();
        public int nroEntrada { get; set; }
        public DateTime fechaHoraVenta { get; set; }
        public float monto { get; set; }
        public int tarifa { get; set; }
        public int idSede { get; set; }
        
        public DataTable getEntradas()
        {
            string sqlTxt = $"SELECT * from Entradas";
            var entradasDTRows = _BD.Consulta(sqlTxt);
            return entradasDTRows;
        }
        public DataTable getEntradasByFecha(DateTime fechahora)
        {
            string sqlTxt = $"SELECT * from Entradas where DATEPART(HOUR, fechaHoraVenta) ={fechahora.ToString("HH")}" +
                $" and (DATEPART(DAY, fechaHoraVenta)= {fechahora.ToString("dd")})" +
                $" and (DATEPART(month, fechaHoraVenta)= {fechahora.ToString("MM")})" +
                $" and (DATEPART(year, fechaHoraVenta)= {fechahora.ToString("yyyy")})";
            var entradasDTRows = _BD.Consulta(sqlTxt);
            return entradasDTRows;
        }
        public int EsDeFechaHora(DateTime fechahora)
        {
            return getEntradasByFecha(fechahora).Rows.Count;
                           
        }
    }
}

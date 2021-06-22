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
        public int nroEntrada { get; set; }
        public DateTime fechaHoraVenta { get; set; }
        public float monto { get; set; }
        public int tarifa { get; set; }
        public int idSede { get; set; }

        AccesoBD _BD = new AccesoBD();
        

        public DataTable getEntradas(DateTime fechahora)
        {
            string sqlTxt = $"SELECT * from Entradas where DATEPART(HOUR, fechaHoraVenta) ={fechahora.ToString("HH")}" +
                $" and (DATEPART(DAY, fechaHoraVenta)= {fechahora.ToString("dd")})" +
                $" and (DATEPART(month, fechaHoraVenta)= {fechahora.ToString("MM")})" +
                $" and (DATEPART(year, fechaHoraVenta)= {fechahora.ToString("yyyy")})";
            var entradasDTRows = _BD.Consulta(sqlTxt);
            return entradasDTRows;
        }
        public int esDeFechaHora(DateTime fechahora)
        {
            return getEntradas(fechahora).Rows.Count;
                           
        }

        public static int ultimoNumero() 
        {
            int ultNum = 0;
            AccesoBD _BD = new AccesoBD();
            string sqlTxt = $"SELECT nroEntrada from Entradas WHERE nroEntrada >= ALL (SELECT nroEntrada FROM Entradas)";
            var tabla = _BD.Consulta(sqlTxt);
            if (tabla.Rows.Count > 0)
            {
                var row = tabla.Rows[0];
                ultNum = Convert.ToInt32(row["nroEntrada"].ToString());
            }
            return ultNum;
        }

        public static void guardarEnBD(List<Entrada> entradas)
        {
            AccesoBD _BD = new AccesoBD();
            foreach (Entrada ent in entradas)
            {
                string sqlTxt = $"INSERT INTO Entradas (fechaHoraVenta, monto, tarifa, sede) VALUES ('{ent.fechaHoraVenta.ToString("yyyy-MM-dd HH:mm")}', {ent.monto}, {ent.tarifa}, {ent.idSede})";
                _BD.EjecutarSQL(sqlTxt);
            }
        }
    }
}

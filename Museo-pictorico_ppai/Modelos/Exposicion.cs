using Museo_pictorico_ppai.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Modelos
{
    public class Exposicion
    {
        private int idExposicion { get; set; }
        private DateTime fechaFin { get; set; }
        private DateTime fechaInicio { get; set; }
        private DateTime fechaInicioReplanificada { get; set; }
        private DateTime horaApertura { get; set; }
        private DateTime horaCierre { get; set; }
        private string nombre { get; set; }
        private List<DetalleExposicion> detallesExposicion { get; set; }
        

        public static List<int> esVigente()
        { 
            List<int> exposiciones = new List<int>();
            Exposicion  e = new Exposicion();
            AccesoBD BD = new AccesoBD();

            string consulta = "SELECT e.idExposicion FROM Exposiciones e WHERE GETDATE() < e.fechaFin";
            OleDbDataReader dr = BD.ConsultaDR(consulta);
     
                while (dr.Read())
                {
                    exposiciones.Add(int.Parse(dr["idExposicion"].ToString()));
                }
                BD.Cerrar();
                return exposiciones;
        }

        public static int calcularDuracionObrasExpuestas(int idSede, List<int> exposiciones)
        {
            AccesoBD BD = new AccesoBD();
            int duracion = 0;

            foreach (var exposicion in exposiciones)
            {
                string consulta = $"SELECT SUM(o.duracionResumida) as 'duracion' FROM Exposiciones e JOIN DetalleExposicion de ON e.idExposicion = de.idExposicion JOIN Obras o ON de.obra = o.idObra WHERE e.sede = {idSede}  AND e.idExposicion = {exposicion} ";
                OleDbDataReader dr = BD.ConsultaDR(consulta);

                while (dr.Read())
                {
                    duracion = duracion + int.Parse(dr["duracion"].ToString());
                }
                BD.Cerrar();
            }
            return duracion;
        }

    }
}

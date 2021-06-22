using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museo_pictorico_ppai.DataBase;

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

        
        public static List<int> esVigente() // busca las exposciones vigentes
        {
            List<int> exposiciones = new List<int>();
            Exposicion e = new Exposicion();
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

        public static int calcularDuracionObrasExpuestas(int idSede, List<int> exposiciones) // obtiene la duracion de las obras expuestas        {            return DetalleExposicion.buscarDuracionObras(idSede, exposiciones);        }


    }
}

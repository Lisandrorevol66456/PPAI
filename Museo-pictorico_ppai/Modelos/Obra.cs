using Museo_pictorico_ppai.DataBase;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Modelos
{
    public class Obra
    {
        private int idObra { get; set; }
        private float alto { get; set; }
        private float ancho { get; set; }
        private long codigoSensor { get; set; }
        private string descripcion { get; set; }
        private float duracionExtendida { get; set; }
        private float duracionResumida { get; set; }
        private DateTime fechaCreacion { get; set; }
        private string nombreObra { get; set; }
        private float peso { get; set; }
        private float valuacion { get; set; }


        public static int getDuracionResumida(int idSede, List<int> exposiciones) // obtiene la duracion resumida de las obras expuestas
        {            AccesoBD BD = new AccesoBD();            int duracionResumida = 0;            foreach (var exposicion in exposiciones)            {                string consulta = $"SELECT SUM(o.duracionResumida) as 'duracion' FROM Exposiciones e JOIN DetalleExposicion de ON e.idExposicion = de.idExposicion JOIN Obras o ON de.obra = o.idObra WHERE e.sede = {idSede}  AND e.idExposicion = {exposicion} ";                OleDbDataReader dr = BD.ConsultaDR(consulta);                while (dr.Read())                {                    duracionResumida = duracionResumida + int.Parse(dr["duracion"].ToString());                }                BD.Cerrar();            }            return duracionResumida;        }


    }
}

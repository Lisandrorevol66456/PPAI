using System;
using System.Collections.Generic;
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


        public float getDuracionResumida() => duracionResumida;

    }
}

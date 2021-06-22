using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Modelos
{
    public class DetalleExposicion
    {
        private string lugarAsignado { get; set; }
        private int obra { get; set; }



        public static int buscarDuracionObras(int idSede, List<int> exposiciones) // método para obtener la duración resumida de las obras        {            return Obra.getDuracionResumida(idSede, exposiciones);        }

    }
}

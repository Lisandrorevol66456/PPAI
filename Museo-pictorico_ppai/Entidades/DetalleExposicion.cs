using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Gestores.Entidades
{
    class DetalleExposicion
    {
        private string lugarAsignado;

        public DetalleExposicion() 
        {
        
        }

        public string LugarAsignado { get => lugarAsignado; set => lugarAsignado = value; }
    }
}

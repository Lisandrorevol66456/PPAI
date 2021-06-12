using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Modelos
{
    public class Sede
    {
        public long Cupo = 500;
    

        public bool CheckearCupo(long entradasIngresadas)
        {
           // var cupo = this._sede.Cupo;

            if (Cupo - entradasIngresadas >= 0)
            {
                return true;
            }
            return false;
        }

    }
}

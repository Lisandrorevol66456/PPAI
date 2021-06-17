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
        public long visitantes { get; set; }
    

        public bool CheckearCupo(long entradasIngresadas)
        {         
            if (Cupo - (entradasIngresadas+ visitantes) >= 0)
            {              
                return true;
            }
            return false;
        }
        public long CalcularVisitantes(long entradasIngresadas)
        {                     
           return visitantes += entradasIngresadas ;
        }

    }
}

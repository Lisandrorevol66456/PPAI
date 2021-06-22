using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Gestores.Entidades
{
    public class TipoVisita
    {
       private string nombre;

        public TipoVisita()
        {

        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

    }

}

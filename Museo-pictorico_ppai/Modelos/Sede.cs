using Museo_pictorico_ppai.DataBase;
using Museo_pictorico_ppai.Gestores.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Modelos
{
    
    public class Sede
    {
        AccesoBD _BD = new AccesoBD();
        ReservaVisita _RV = new ReservaVisita();
        Entrada _E = new Entrada();
        public int idSede = 1;
        public long CantidadMaximaVisitantes = 500;
        public long visitantes { get; set; }
    
        public bool CheckearCupo(long entradasIngresadas)
        {
            return CantidadMaximaVisitantes - (entradasIngresadas+ visitantes) >= 0 ? true : false;
        }
        public long CalcularVisitantes(long entradasIngresadas) => visitantes += entradasIngresadas;

        public int CalcularOcupacion(DateTime fechahora)
        {
          int ocupacion = _E.EsDeFechaHora(fechahora) + _RV.EsDeFechaHora(fechahora);
            return ocupacion;
        }

    }
}

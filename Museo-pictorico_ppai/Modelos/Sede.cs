using Museo_pictorico_ppai.DataBase;
using Museo_pictorico_ppai.Entidades;
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
        private int id;
        private int cantidadMaximaVisitantes;
        private int cantMaxPorGuia;
        private long visitantes { get; set; }
        private List<Empleado> empleados;
        private List<int> exposiciones { get; set; }
        AccesoBD _BD = new AccesoBD();
        ReservaVisita _RV = new ReservaVisita();
        Entrada _E = new Entrada();
        Tarifa tarifa = new Tarifa();

        public List<Empleado> empleadosSede
        {
            get => empleados;
            set => empleados = value;
        }
        public int idSede
        {
            get => id;
            set => id = value;
        }
        public int cantidadMaximaVisitantesSede
        {
            get => cantidadMaximaVisitantes;
            set => cantidadMaximaVisitantes = value;
        }
        public int cantMaxPorGuiaSede
        {
            get => cantMaxPorGuia;
            set => cantMaxPorGuia = value;
        }
    
        public int calcularOcupacion(DateTime fechahora)
        {
          int ocupacion = _E.esDeFechaHora(fechahora) + _RV.esDeFechaHora(fechahora);
            return ocupacion;
        }

        public DataTable obtenerTarifasVigentes(int sede)
        {
            return tarifa.mostrarMontosVigentes(sede);
        }

        public int calcularDuracionDeExposicionesVigentes()
        {
            exposiciones = Exposicion.esVigente();
            int duracion = Exposicion.calcularDuracionObrasExpuestas(idSede, exposiciones);
            return duracion;
        }


    }
}

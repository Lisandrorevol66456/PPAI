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
        AccesoBD _BD = new AccesoBD();
        ReservaVisita _RV = new ReservaVisita();
        Entrada _E = new Entrada();
        private int id;
        private int cantidadMaximaVisitantes;
        public long visitantes { get; set; }
        private List<Empleado> empleados;
        private int cantMaxPorGuia;
        Tarifa tarifa = new Tarifa();
        private List<int> exposiciones { get; set; }

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
    
        public bool CheckearCupo(long entradasIngresadas)
        {
            return cantidadMaximaVisitantes - (entradasIngresadas+ visitantes) >= 0 ? true : false;
        }
        public long CalcularVisitantes(long entradasIngresadas) => visitantes += entradasIngresadas;

        public int CalcularOcupacion(DateTime fechahora)
        {
          int ocupacion = _E.EsDeFechaHora(fechahora) + _RV.EsDeFechaHora(fechahora);
            return ocupacion;
        }

        public DataTable obtenerTarifasVigentes()
        {
            return tarifa.mostrarMontosVigentes();
        }

        public int calcularDuracionDeExposicionesVigentes()
        {
            exposiciones = Exposicion.esVigente();
            int duracion = Exposicion.calcularDuracionObrasExpuestas(idSede, exposiciones);
            return duracion;
        }


    }
}

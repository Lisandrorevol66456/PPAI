using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Entidades
{
    public class Tarifa
    {
        private DateTime fechaFinVigencia;
        private DateTime fechaInicioVigencia;
        private int monto;
        private int montoAdicionalGuia;
        //private TipoDeEntrada tipoDeEntrada;
        //private TipoVisita tipoVisita;

        public Tarifa()
        {

        }

        public DateTime fechaFinVigenciaTarifa
        {
            get => fechaFinVigencia;
            set => fechaFinVigencia = value;
        }

        public DateTime fechaInicioVigenciaTarifa
        {
            get => fechaInicioVigencia;
            set => fechaInicioVigencia = value;
        }

        public int montoTarifa
        {
            get => monto;
            set => monto = value;
        }

        public int montoAdicionalGuiaTarifa
        {
            get => montoAdicionalGuia;
            set => montoAdicionalGuia = value;
        }

        //public TipoDeEntrada tipoDeEntradaTarifa
        //{
        //    get => tipoDeEntrada;
        //    set => tipoDeEntrada = value;
        //}

        //public TipoVisita tipoVisitaTarifa
        //{
        //    get => tipoVisita;
        //    set => tipoVisita = value;
        //}
    }
}

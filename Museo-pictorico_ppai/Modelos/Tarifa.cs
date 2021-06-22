using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Museo_pictorico_ppai.DataBase;
using Museo_pictorico_ppai.Gestores.Entidades;

namespace Museo_pictorico_ppai.Entidades
{
    public class Tarifa
    {
        private DateTime fechaFinVigencia;
        private DateTime fechaInicioVigencia;
        private int monto;
        private int montoAdicionalGuia;
        private TipoDeEntrada tipoDeEntrada;
        private TipoVisita tipoVisita;
        private int id;

        AccesoBD BD = new AccesoBD();
        public Tarifa()
        {

        }
        public int idTarifa
        {
            get => id;
            set => id = value;
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

        public TipoDeEntrada tipoDeEntradaTarifa
        {
            get => tipoDeEntrada;
            set => tipoDeEntrada = value;
        }

        public TipoVisita tipoVisitaTarifa
        {
            get => tipoVisita;
            set => tipoVisita = value;
        }

        public DataTable mostrarMontosVigentes(int sede) // funcion para obtener los montos de las tarifas vigentes para una sede
        {
            string sqlTxt = $"select t.id,tv.nombre as 'tipoVisita',te.nombre as'tipoEntrada',t.precio from tarifas t join tipoEntrada te on t.tipoEntrada = te.idTipo join TipoVisita tv on t.tipoVisita = tv.id WHERE t.sede = {sede} AND t.fechaFinVigencia is Null order by tv.nombre; ";
            var tarifasDTRows = BD.Consulta(sqlTxt);
            return tarifasDTRows;
        }
    }
}

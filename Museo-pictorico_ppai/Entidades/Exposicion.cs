using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Gestores.Entidades
{
    class Exposicion
    {
        private DateTime fechaFin;
        private DateTime fechaFinReplanificada;
        private DateTime fechaInicio;
        private DateTime fechaInicioReplanificada;
        private DateTime horaApertura;
        private DateTime horaCierre;
        private string nombre;

        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public DateTime FechaFinReplanificada { get => fechaFinReplanificada; set => fechaFinReplanificada = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaInicioReplanificada { get => fechaInicioReplanificada; set => fechaInicioReplanificada = value; }
        public DateTime HoraApertura { get => horaApertura; set => horaApertura = value; }
        public DateTime HoraCierre { get => horaCierre; set => horaCierre = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}

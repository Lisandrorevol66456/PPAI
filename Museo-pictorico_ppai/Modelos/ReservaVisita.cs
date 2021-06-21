using Museo_pictorico_ppai.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Gestores.Entidades
{
    class ReservaVisita
    {
        AccesoBD _BD = new AccesoBD();
        private int cantidadAlumnos;
        private int cantidadAlumnosConfirmada;
        private int duracionEstimada;
        private DateTime fechaHoraCreacion;
        private DateTime fechaHoraReserva;
        private DateTime horaFinReal;
        private DateTime horaInicioReal;
        private int numeroReserva;


        public ReservaVisita() 
        { 
        
        }

        public int cantAlumnos
        {
            get => cantidadAlumnos;
            set => cantidadAlumnos = value;
        }
        public int cantAlumnosConfirmada
        {
            get => cantidadAlumnosConfirmada;
            set => cantidadAlumnosConfirmada = value;
        }

        public int duracionEstim
        {
            get => duracionEstimada;
            set => duracionEstimada = value;
        }
        
        public DateTime fechaYHoraCreacion
        {
            get => fechaHoraCreacion;
            set => fechaHoraCreacion = value; 
        }
        public DateTime fechaYHoraReserva
        {
            get => fechaHoraReserva;
            set => fechaHoraReserva = value;
        }
        public DateTime horaDeFinReal
        {
            get => horaFinReal;
            set => horaFinReal = value;
        }
        public DateTime horaDeInicioReal
        {
            get => horaInicioReal;
            set => horaInicioReal = value;
        }
        public int numeroDeReserva
        {
            get => numeroReserva;
            set => numeroReserva = value;
        }

        public DataTable getreservasByFecha(DateTime fechahora)
        {
            string sqlTxt = $"SELECT * from Reservas where DATEPART(HOUR, fechaHoraReserva) ={fechahora.ToString("HH")}" +
                $" and (DATEPART(DAY, fechaHoraReserva)= {fechahora.ToString("dd")})" +
                $" and (DATEPART(month, fechaHoraReserva)= {fechahora.ToString("MM")})" +
                $" and (DATEPART(year, fechaHoraReserva)= {fechahora.ToString("yyyy")})";
            var entradasDTRows = _BD.Consulta(sqlTxt);
            return entradasDTRows;
        }
        public int EsDeFechaHora(DateTime fechahora)
        {
            return getreservasByFecha(fechahora).Rows.Count;
        
        }
           
    }
}

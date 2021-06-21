using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Entidades
{
    public class Sesion
    {
        private DateTime fechaFin;
        private DateTime fechaInicio;
        private DateTime horaInicio;
        private DateTime horaFin;
        private Usuario usuario;

        public Sesion()
        {

        }

        public DateTime fechaFinalSesion
        {
            get => fechaFin;
            set => fechaFin = value;
        }

        public DateTime fechaInicioSesion
        {
            get => fechaInicio;
            set => fechaInicio = value;
        }

        public DateTime horaInicioSesion
        {
            get => horaInicio;
            set => horaInicio = value;
        }

        public DateTime horaFinSesion
        {
            get => horaFin ;
            set => horaFin = value;
        }

        public Usuario usuarioSesion
        {
            get => usuario;
            set => usuario = value;
        }

        public Empleado getEmpleadoEnSesion() {
            return this.usuario.empleadoUsuario;
        }




    }
}

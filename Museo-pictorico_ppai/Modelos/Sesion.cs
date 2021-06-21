using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Entidades
{
    public class Sesion
    {
        private string fechaFin;
        private string fechaInicio;
        private string horaInicio;
        private string horaFin;
        private Usuario usuario;

        public Sesion()
        {

        }

        

        public Usuario usuarioSesion
        {
            get => usuario;
            set => usuario = value;
        }
        public string HoraFin { get => horaFin; set => horaFin = value; }
        public string HoraInicio { get => horaInicio; set => horaInicio = value; }
        public string FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public string FechaFin { get => fechaFin; set => fechaFin = value; }

        public Empleado getEmpleadoEnSesion() {
            return this.usuario.empleadoUsuario;
        }




    }
}

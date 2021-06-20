using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Entidades
{
    public class Usuario
    {
        private DateTime caducidad;
        private string contraseña;
        private string nombre;
        private Empleado empleado;

        public Usuario()
        {

        }

        public DateTime caducidadUsuario
        {
            get => caducidad;
            set => caducidad = value;
        }

        public string contraseñaUsuario
        {
            get => contraseña;
            set => contraseñaUsuario = value;
        }

        public string nombreUsuario
        {
            get => nombre;
            set => nombre = value;
        }

        public Empleado empleadoUsuario
        {
            get => empleado;
            set => empleado = value;
        }
    }
}

using System;

namespace Museo_pictorico_ppai.Entidades
{
    public class Empleado
    {
        private string apellido;
        private int codigoValidacion;
        private string cuit;
        private string dni;
        private string domicilio;
        private DateTime fechaIngreso;
        private DateTime fechaNacimiento;
        private string mail;
        private string nombre;
        private string sexo;
        private string telefono;

        public Empleado()
        {

        }

        public string apellidoEmpleado
        {
            get => apellido;
            set => apellido = value;
        }

        public int codigoValidacionEmpleado
        {
            get => codigoValidacion;
            set => codigoValidacion = value;
        }

        public string cuitEmpleado 
        {
            get => cuit;
            set => cuit = value;
        }

        public string dniEmpleado
        {
            get => dni;
            set => dni = value;
        }

        public string domicilioEmpleado
        {
            get => domicilio;
            set => domicilio = value;
        }

        public DateTime fechaIngresoEmpleado      
        {
            get => fechaIngreso;
            set => fechaIngreso = value;
        }

        public DateTime fechaNacimientoEmpleado
        {
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }

        public string mailEmpleado
        {
            get => mail;
            set => mail = value;
        }

        public string nombreEmpleado
        {
            get => nombre;
            set => nombre = value;
        }

        public string sexoEmpleado
        {
            get => sexo;
            set => sexo = value;
        }

        public string telefonoEmpleado
        {
            get => telefono;
            set => telefono = value;
        }
    }
}

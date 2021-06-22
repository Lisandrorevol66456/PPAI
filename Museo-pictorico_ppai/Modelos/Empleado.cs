using Museo_pictorico_ppai.DataBase;
using Museo_pictorico_ppai.Modelos;
using System;

namespace Museo_pictorico_ppai.Entidades
{
    public class Empleado
    {
        private string apellido;
        private int codigoValidacion;
        private long cuit;
        private long dni;
        private string domicilio;
        private DateTime fechaIngreso;
        private DateTime fechaNacimiento;
        private string mail;
        private string nombre;
        private string sexo;
        private long telefono;

        AccesoBD _BD;

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

        public long cuitEmpleado 
        {
            get => cuit;
            set => cuit = value;
        }

        public long dniEmpleado
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

        public long telefonoEmpleado
        {
            get => telefono;
            set => telefono = value;
        }

        public Sede obtenerSede()
        {
            _BD = new AccesoBD();
            Sede sedeRes = null;
            var sqlstring = $"SELECT E.sede FROM Empleados E WHERE E.dni={this.dniEmpleado}";
            var tabla = _BD.Consulta(sqlstring); //Obtiene la sede donde trabaja el empleado
            if (tabla.Rows.Count > 0) 
            {
                var row = tabla.Rows[0];
                var numSede = (int)row["sede"];
                var sqlstring2 = $"SELECT * FROM Sede WHERE idSede={numSede}";
                var tabla2 = _BD.Consulta(sqlstring2); //Obtiene los datos de la sede
                if(tabla2.Rows.Count > 0) //Carga los datos de la sede
                {
                    var row2 = tabla2.Rows[0];
                    sedeRes = new Sede();
                    sedeRes.idSede = (int)row2["idSede"];
                    sedeRes.cantidadMaximaVisitantesSede = (int)row2["cantMaxVisitantes"];
                    sedeRes.cantMaxPorGuiaSede = (int)row2["cantMaxiXguia"];
                }
            }
            return sedeRes;
        }

    }
}

using Museo_pictorico_ppai.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Entidades
{
    public class Usuario
    {
        AccesoBD _BD = new AccesoBD();
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
            set => contraseña = value;
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

        public Usuario sesionhardcodeada()
        {
            Usuario usRes = null;
            var sqlString = "SELECT U.nombre, E.dni FROM Usuario U JOIN Empleados E ON (U.dniEmpleado=E.dni) WHERE U.nombre='Bsalas'";
            var tabla = _BD.Consulta(sqlString);
            if(tabla.Rows.Count > 0)
            {
                var row = tabla.Rows[0];
                usRes = new Usuario();
                usRes.nombreUsuario = row["nombre"].ToString();
                Empleado emp = new Empleado() {dniEmpleado= Convert.ToInt64(row["dni"].ToString()) };
                usRes.empleadoUsuario = emp;

            }
            return usRes;

        }
    }
}

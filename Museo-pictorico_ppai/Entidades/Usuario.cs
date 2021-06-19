using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.Gestores.Entidades
{
    public class Usuario
    {
        private DateTime caducidad;
        private string password;
        private string nombre;

        public Usuario() 
        {
        
        }

        public DateTime Caducidad 
        {
            get => caducidad;
            set => caducidad = value;
        }
        public string Password
        {
            get => password;
            set => password = value;
        }

        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public static DataTable ConocerUsuario() 
        {
            DataTable tabla = new DataTable();
            return tabla;
        }



    }

}

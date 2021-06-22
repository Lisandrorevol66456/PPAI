using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museo_pictorico_ppai.DataBase
{
    class AccesoBD
    {
        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        readonly string  cadena_conexion = "Provider=SQLNCLI11;workstation id=museo-ppai.mssql.somee.com;packet size=4096;user id=Lisandro1905_;pwd=Belgrano1905;data source=museo-ppai.mssql.somee.com;persist security info=False;initial catalog=museo-ppai";

        public void Conectar()
        {

            conexion.ConnectionString = cadena_conexion;

            conexion.Open();

            cmd.Connection = conexion;

            cmd.CommandType = CommandType.Text;

        }

        public OleDbDataReader ConsultaDR(string comando)
        {
            Conectar();

            cmd.CommandText = comando;

            return cmd.ExecuteReader();
        }

        public void Cerrar()
        {

            conexion.Close();
        }
        public DataTable Consulta(string comando)
        {

            //ejecuta el procedimiento local <conectar>
            Conectar();
            //asigna a <cmd> el comando que se debe ejecutar, que viene por parámetro
            //de entrada <comando>
            cmd.CommandText = comando;
            //instancia un objeto <tabla> del tipo DataTable
            DataTable tabla = new DataTable();
            //aquí dos acciones. 1) Ejecuta el comando SQL que ingreso por parámetro de entrada
            //en el pedazo de comando <cmd.ExecuteReader()>
            //2) Carga la tabla con el valor de resultado del comando SQL en el pedazo de texto
            //<tabla.Load(. . . )>
            tabla.Load(cmd.ExecuteReader());
            //ejecuta el procedimiento <cerrar>
            Cerrar();
            //devuelve el valor calculado a través de la función
            return tabla;
        }

        public bool EjecutarSQL(string comando)
        {
            Conectar();

            cmd.CommandText = comando;

            var filasAfectadas = cmd.ExecuteNonQuery(); //Cantidad de filas afectadas

            //ejecuta el procedimiento <cerrar>
            Cerrar();

            return filasAfectadas > 0;
        }

        public int EjecutarTransaccion(string comando)
        {
            var id = 0;
            cmd.CommandText = comando;

            if (cmd.ExecuteNonQuery() > 0)
            {
                string consultaGetId = "Select @@Identity";
                cmd.CommandText = consultaGetId;
                id = int.Parse(cmd.ExecuteScalar()?.ToString());
            }
            return id;
        }

        public DataTable ConsultaDuranteTransaccion(string comando)
        {

            cmd.CommandText = comando;
            //instancia un objeto <tabla> del tipo DataTable
            DataTable tabla = new DataTable();

            tabla.Load(cmd.ExecuteReader());

            //devuelve el valor calculado a través de la función
            return tabla;
        }

        public bool EjecutarSentenciaPreparadaSQL(string comando)
        {
            Conectar();

            cmd.CommandText = comando;

            var filasAfectadas = cmd.ExecuteNonQuery(); //Cantidad de filas afectadas

            //ejecuta el procedimiento <cerrar>
            Cerrar();

            return filasAfectadas > 0;
        }

        public OleDbTransaction IniciarTransaccion()
        {
            Conectar();
            var transaccion = conexion.BeginTransaction();
            cmd.Transaction = transaccion;
            return transaccion;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOdontologico.Base_de_Datos
{
    class Consultorio_BD
    {

        SqlConnection conexion = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        //Para poner la barra agrgar @ o \\ .
        string cadena_conexion = "Data Source=(localdb)\\SQLPymes;Initial Catalog=Consultorio;Integrated Security=True";
        private void conectar()
        {
            //Se establece a la cadena de coneccion que se va a conectar
            conexion.ConnectionString = cadena_conexion;
            // se abre la conexion
            conexion.Open();

            cmd.Connection = conexion;

            cmd.CommandType = CommandType.Text;

        }
        public void cerrar()
        {

            conexion.Close();
        }

        public DataTable consulta(string comando)
        {

            //ejecuta el procedimiento local <conectar>
            conectar();
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
            cerrar();
            //devuelve el valor calculado a través de la función
            return tabla;
        }
        public bool EjecutarSQL(string comando)
        {
            conectar();

            cmd.CommandText = comando;

            var filasAfectadas = cmd.ExecuteNonQuery(); //Cantidad de filas afectadas

            //ejecuta el procedimiento <cerrar>
            cerrar();

            return filasAfectadas > 0;
        }

    }
}

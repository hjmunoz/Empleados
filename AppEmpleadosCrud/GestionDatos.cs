using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.Types;
using MySql.Data.MySqlClient;

namespace AppEmpleadosCrud
{
    public class GestionDatos
    {

        public MySqlConnection Conexion;
        public string error;


        public GestionDatos() 
        {
            this.Conexion = ConexionMysql.GetConexion();
        }
        //Obtener todos los registros de la tabla
        public List<Empleado> LeerTodos() 
        {
            List<Empleado> listaEmpleados = new List<Empleado>();
            string sql = "SELECT * FROM empleados;";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion);
            MySqlDataReader resultado = cmd.ExecuteReader();

            while (resultado.Read()) 
            {
                Empleado MyEmpleado = new Empleado();
                MyEmpleado.Codigo = resultado.GetString(1);
                MyEmpleado.Nombre = resultado.GetString(2);
                MyEmpleado.Apellido = resultado.GetString(3);
                MyEmpleado.Cargo = resultado.GetString(4);
                MyEmpleado.Area = resultado.GetString(5);
                MyEmpleado.Salario = resultado.GetString(6);
                MyEmpleado.Ciudad = resultado.GetString(7);
                listaEmpleados.Add(MyEmpleado);
            }

            resultado.Close();
            return listaEmpleados;
        }

    }
}
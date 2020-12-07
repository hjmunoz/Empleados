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
        /*---------------Insertar Datos------------------*/

        //------------------------------------------------
        public Boolean ExisteEmpleado(string Codigo)
        {
            string sql = "select * From empleados where codigo = @codigo";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion);
            cmd.Parameters.AddWithValue("@codigo", Codigo);
            MySqlDataReader resultado = cmd.ExecuteReader();

            if (resultado.Read())
            {
                resultado.Close();
                return true;
            }
            else
            {
                resultado.Close();
                return false;
            }
        }

        /*---------------Insertar Datos------------------*/

        public Boolean InsertarEmpleado(Empleado MyEmpleado)
        {
            Boolean rta = false;

            try
            {
                string sql = "insert into empleados (codigo, nombre, apellido, cargo, salario, area, ciudad) values (@codigo, @nombre, @apellido, @cargo, @salario, @area, @ciudad)";
                MySqlCommand cmd = new MySqlCommand(sql, Conexion);
                cmd.Parameters.AddWithValue("@codigo", MyEmpleado.Codigo);
                cmd.Parameters.AddWithValue("@nombre", MyEmpleado.Nombre);
                cmd.Parameters.AddWithValue("@apellido", MyEmpleado.Apellido);
                cmd.Parameters.AddWithValue("@cargo", MyEmpleado.Cargo);
                cmd.Parameters.AddWithValue("@salario", MyEmpleado.Salario);
                cmd.Parameters.AddWithValue("@area", MyEmpleado.Area);
                cmd.Parameters.AddWithValue("@ciudad", MyEmpleado.Ciudad);
                cmd.ExecuteNonQuery();
                rta = true;
            }
            catch (MySqlException exeption)
            {

                this.error = exeption.Message;
            }

            return rta;
        }

        /*-------------------------Traer Un Empleado----------------------*/
        public Empleado ConsultaEmpleado(string codigo)
        {
            string sql = "SELECT * FROM empleados where codigo=@codigo";
            MySqlCommand cmd = new MySqlCommand(sql, Conexion);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            MySqlDataReader resultado = cmd.ExecuteReader();

            if (resultado.Read())
            {
                Empleado MyEmpleado = new Empleado();
                MyEmpleado.Codigo = resultado.GetString(1);
                MyEmpleado.Nombre = resultado.GetString(2);
                MyEmpleado.Apellido = resultado.GetString(3);
                MyEmpleado.Cargo = resultado.GetString(4);
                MyEmpleado.Area = resultado.GetString(5);
                MyEmpleado.Salario = resultado.GetString(6);
                MyEmpleado.Ciudad = resultado.GetString(7);
                resultado.Close();
                return MyEmpleado;
            }
            else
            {
                resultado.Close();
                return null;
            }
            
        }

        //Editar los datos de un empleado
        public Boolean EditarEmpleado(Empleado MyEmpleado)
        {
            Boolean rta = false;

            try
            {
                string sql = "update empleados set nombre = @nombre, apellido = @apellido, cargo = @cargo, salario = @salario, area = @area, ciudad = @ciudad where codigo = @codigo";
                MySqlCommand cmd = new MySqlCommand(sql, Conexion);
                cmd.Parameters.AddWithValue("@codigo", MyEmpleado.Codigo);
                cmd.Parameters.AddWithValue("@nombre", MyEmpleado.Nombre);
                cmd.Parameters.AddWithValue("@apellido", MyEmpleado.Apellido);
                cmd.Parameters.AddWithValue("@cargo", MyEmpleado.Cargo);
                cmd.Parameters.AddWithValue("@salario", MyEmpleado.Salario);
                cmd.Parameters.AddWithValue("@area", MyEmpleado.Area);
                cmd.Parameters.AddWithValue("@ciudad", MyEmpleado.Ciudad);
                cmd.ExecuteNonQuery();
                rta = true;
            }
            catch (MySqlException exeption)
            {

                this.error = exeption.Message;
            }

            return rta;
        }
        //Eliminar los datos de un empleado

        public Boolean EliminarEmpleado(string codigo)
        {
            Boolean rta = false;

            try
            {
                string sql = "delete from empleados where codigo = @codigo";
                MySqlCommand cmd = new MySqlCommand(sql, Conexion);
                cmd.Parameters.AddWithValue("@codigo", codigo);               
                cmd.ExecuteNonQuery();
                rta = true;
            }
            catch (MySqlException exeption)
            {

                this.error = exeption.Message;
            }

            return rta;
        }
    }
}
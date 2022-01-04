using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos.Clases
{
    class Personas
    {
        private static string cadenacon = @"server=DESKTOP-D1QBCII\SQLEXPRESS; database=TI2021; Integrated Security=true";
        public static int insertar(string cedula, string apellidos,string nombres,
            DateTime fechaNacimiento, double peso)
        {
            SqlConnection conexion = new SqlConnection(cadenacon);
            //2. Definir la operacion
            string sql = "insert into personas(cedula, apellidos, nombres, fechaNacimiento, peso)";
            sql += "values(@cedula, @apellidos, @nombres, @fechaNacimiento, @peso)";
            //3. ejecutar la operacion
            SqlCommand comando = new SqlCommand(sql, conexion);
            //3.1 configurar los parametros @cedula, @apellidos, @nombres, @fechadenacimiento, @peso
            comando.Parameters.Add(new SqlParameter("@cedula", cedula));
            comando.Parameters.Add(new SqlParameter("@apellidos",apellidos));
            comando.Parameters.Add(new SqlParameter("@nombres", nombres));
            comando.Parameters.Add(new SqlParameter("@fechaNacimiento",fechaNacimiento));
            comando.Parameters.Add(new SqlParameter("@peso", peso));
            //3.2 abrir la conexion 
            conexion.Open();
            //3.3 Insertar el registro en la Base de datos
            int res = comando.ExecuteNonQuery();
            //4 Cerrar la conexion
            conexion.Close();

            return res;
        }

        public static int borrar(string cedula)
        {
            SqlConnection conexion = new SqlConnection(cadenacon);
            //2. Definir la operacion
            string sql = "delete from personas ";
            sql += " where cedula=@cedula";
            //3. ejecutar la operacion
            SqlCommand comando = new SqlCommand(sql, conexion);
            //3.1 configurar el parametro @cedula
            comando.Parameters.Add(new SqlParameter("@cedula", cedula));
            
            //3.2 abrir la conexion 
            conexion.Open();
            //3.3 borra el registro en la Base de datos
            int res = comando.ExecuteNonQuery();
            //4 Cerrar la conexion
            conexion.Close();

            return res;
        }

        private static DataTable getpersona(string cedula = "")
        {

            SqlConnection conexion = new SqlConnection(cadenacon);

            string sql = "";

            sql = "select cedula, apellidos, nombres, upper(apellidos+ ' ' + nombres) as nombreCompleto, fechaNacimiento, peso ";
            sql += "from Personas  order by apellidos, nombres";


            SqlCommand comando = new SqlCommand(sql, conexion);
            SqlDataAdapter ad1 = new SqlDataAdapter(comando);

            //pasar los datos del adaptador a un datatable
            DataTable dt = new DataTable();
            ad1.Fill(dt);

            return dt;
        }

    }

}


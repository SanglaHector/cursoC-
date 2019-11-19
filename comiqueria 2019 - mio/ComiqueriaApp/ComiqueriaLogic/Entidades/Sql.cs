using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ComiqueriaLogic.Entidades
{
    public class Sql
    {
        private SqlConnection conexion;
        private SqlCommand comando;

        public Sql()
        {
            string conectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Comiqueria;Integrated Security=True";
            this.conexion = new SqlConnection(conectionString);
            this.comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            this.comando.Connection = this.conexion;
        }
        public void Leer(string tabla, out List<Producto> datos)
        {
            List<Producto> productos = new List<Producto>();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("SELECT * from " + tabla);
            this.comando.CommandText = sb.ToString();
            this.conexion.Open();
            SqlDataReader reader = this.comando.ExecuteReader();

            while (reader.Read())
            {
                int codigo = int.Parse(reader["Codigo"].ToString());
                string descripcion = reader["Descripcion"].ToString();
                double precio;
                Double.TryParse(reader["Precio"].ToString(), out precio);
                int stock = int.Parse(reader["Stock"].ToString());


                Producto unProducto = new Producto(codigo,descripcion,stock,precio);
                productos.Add(unProducto);
            }
            this.conexion.Close();
            datos = productos;
        }
        public void Guardar(string tabla,string descripcion, double precio,int stock)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("INSERT into " + tabla + "SET (Descripcion, Precio, Stock) VALUES (\'" +descripcion+ "\'," + precio + "," + stock +";");
            string consulta = sb.ToString();
            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();   
        }
        public void Modificar(string tabla,int codigo, double precio)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("UPDATE  " + tabla + "SET (Descripcion) VALUES (" + precio + "WHERE Codigo = " + codigo + ";");
            string consulta = sb.ToString();
            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void Eliminar(string tabla, int codigo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("DELETE FROM " + tabla +  "WHERE Codigo = " + codigo + ";");
            string consulta = sb.ToString();
            comando.CommandText = consulta;
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}

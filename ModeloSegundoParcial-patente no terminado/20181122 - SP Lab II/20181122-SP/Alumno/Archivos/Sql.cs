using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
  public class Sql : IArchivo<Queue<Patente>> 
  {
    private SqlCommand comando;
    private SqlConnection conexion;
    public void Guardar(string tabla, Queue<Patente>datos)
    {
      foreach(Patente item in datos)
      {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("INSERT into " + tabla + "SET (patente,tipo) VALUES (" + item.CodigoPatente + "," +item.TipoCodigo +";");
        String consulta = sb.ToString();
        comando.CommandText = consulta;
        conexion.Open();
        comando.ExecuteNonQuery();
        conexion.Close();
      }
    }
    public void Leer(string tabla, out Queue<Patente> datos)
    {
      Queue<Patente> patentes = new Queue<Patente>();
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("SELECT * from " + tabla);
      this.comando.CommandText = sb.ToString();
      this.conexion.Open();
      SqlDataReader reader = this.comando.ExecuteReader();

      while (reader.Read())
      {
        string patente = reader["patente"].ToString();
        string tipo = reader["tipo"].ToString();
        if(tipo == "Vieja")
        {
          Patente unaPatente = new Patente(patente, Patente.Tipo.Vieja);
          patentes.Enqueue(unaPatente);
        }
        else
        {
          Patente unaPatente = new Patente(patente, Patente.Tipo.Mercosur);
          patentes.Enqueue(unaPatente);
        }
      }
      this.conexion.Close();
      datos = patentes;
    }

    public Sql()
    {
      string conectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=patentes-sp-2018;Integrated Security=True";
      this.conexion = new SqlConnection(conectionString);
      this.comando = new SqlCommand();
      comando.CommandType = System.Data.CommandType.Text;
            this.comando.Connection = this.conexion;
    }

  }
}

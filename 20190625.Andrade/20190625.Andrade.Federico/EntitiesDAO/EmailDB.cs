using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using Entities;

namespace Persistencia
{
    public class EmailDB : IData<List<EmisorDeEmails>>
    {
        private readonly string connectionString;
        /// <summary>
        /// Asigna un valor al connectionString
        /// </summary>
        public EmailDB()
        {
            connectionString = EntitiesDAO.Properties.Settings.Default.myDB;
        }

        public void Guardar(Emisor emisor)
        {
            EmailDB db = new EmailDB();
            SqlConnection connection = new SqlConnection(db.connectionString);
            try
            {
                connection.Open();
                string query = $"INSERT INTO mensaje , producto, email values ({emisor.Mensaje}) ({emisor.Producto.ToString()}) ({((EmisorDeEmails)emisor).Email.ToString()})";
                SqlCommand comando = new SqlCommand(query, connection);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                connection.Close();
            }
        }

        public List<EmisorDeEmails> Leer()
        {
            EmailDB db = new EmailDB();
            SqlConnection connection = new SqlConnection(db.connectionString);
            try
            {

                List<EmisorDeEmails> emisores = new List<EmisorDeEmails>();
                SqlCommand comando = new SqlCommand("", connection);
                EProducto producto;
                comando.CommandText = "SELECT * FROM Emails2";
                connection.Open();
                SqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    if (Enum.TryParse(dataReader["producto"].ToString(), out producto))
                    {
                        emisores.Add(new EmisorDeEmails(dataReader["mensaje"].ToString(), producto, dataReader["email"].ToString()));
                    }
                }
                return emisores;
            }
            catch
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}


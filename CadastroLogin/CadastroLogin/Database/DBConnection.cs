using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CadastroLogin.Database
{
    public class DBConnection : IDisposable
    {
        private readonly SqlConnection connection;

        public DBConnection()
        {
        connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
        connection.Open();

        }

        public void ExecuteCommand(string StrQuery)
        {
            var Command = new SqlCommand
            {
                CommandText = StrQuery,
                CommandType = CommandType.Text,
                Connection = connection
            };

            Command.ExecuteNonQuery();
        }


<<<<<<< HEAD
        public SqlDataReader RetornaComando(string Strquery)
        {
            var comando = new SqlCommand(Strquery, connection);
            return comando.ExecuteReader();

        }
=======
        public SqlDataReader ReturnCommand(string Strquery)
        {
            var comando = new SqlCommand(Strquery, connection);
            return comando.ExecuteReader();
>>>>>>> 7a429bc8fcde82a01bb570d9298dffb61d150209

        }

        public void Dispose()
        {
           connection.Close();
        }
    }
}
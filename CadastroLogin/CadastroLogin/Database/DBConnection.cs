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

        //ERRADO TAMBÉM
        public void ReturnCommand(string StrQuery)
        {
            var Command = new SqlCommand
            {
                CommandText = StrQuery,
                CommandType = CommandType.Text,
                Connection = connection
               
            };
            Command.ExecuteReader();
        }


        public void Dispose()
        {
           connection.Close();
        }
    }
}
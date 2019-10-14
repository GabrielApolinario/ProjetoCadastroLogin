using CadastroLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CadastroLogin.Database
{
    public class CommandsSQL
    {
        private DBConnection db;

        public void Insert(User user)
        {
            var StrQuery = "";
            StrQuery += "INSERT INTO tb_User(Name_User, Login_User, Password_User)";
            StrQuery += string.Format("VALUES('{0}', '{1}', '{2}')", user.Name, user.Login, user.Password);

            using (db = new DBConnection())
            {
                db.ExecuteCommand(StrQuery);
            }
        }

        //TESTAR ESSE METODO
        public List<User>Listar()
        {
            var db = new DBConnection();
            var strQuery = "SELECT * FROM tb_user;";
            var retorno = db.ReturnCommand(strQuery);
            return ListaDeUsuario(retorno);
        }

        public List<User> ListaDeUsuario(SqlDataReader retorno)
        {
            var usuarios = new List<User>();

            while (retorno.Read())
            {
                var TempUsuario = new User()
                {
                    Login = retorno["Login"].ToString(),
                    Password = retorno["Password"].ToString(),

                };
                usuarios.Add(TempUsuario);
            }
            retorno.Close();
            return usuarios;
        }




    }
}
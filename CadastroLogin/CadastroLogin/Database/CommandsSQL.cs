using CadastroLogin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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


    }
}
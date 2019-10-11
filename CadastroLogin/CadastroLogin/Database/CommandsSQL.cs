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


        //METODO ERRADO, UTILIZAR LISTA PARA TRAZER RESULTADOS
        //public  SqlDataReader CheckLogin(Login loginUser)
        //{
 
        //    var StrQuery = "";
        //    StrQuery += "SELECT login_user, password_user FROM tb_user ";
        //    StrQuery += string.Format("WHERE login_user = '{0}' AND password_user = '{1}'", loginUser.User, loginUser.Password);

        //    using (db = new DBConnection())
        //    {
        //        db.ReturnCommand(StrQuery);
        //    }
        //}

        //public List<Login> LoginValidate(Login loginUser)
        //{
        //    var strQuery = "SELECT login_user, password_user FROM tb_user ";
        //    strQuery += string.Format("WHERE login_user = '{0}' AND password_user = '{1}'", loginUser.User, loginUser.Password);
        //    List<Login> logins = new List<Login>();

        //    db.ReturnCommand(strQuery);


        //    return logins;
        //}
           
        
        

    }
}
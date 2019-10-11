using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadastroLogin.Models;
using System.Data.SqlClient;
using CadastroLogin.Database;

namespace CadastroLogin.Controllers
{
    public class AuthenticationController : Controller
    {
        CommandsSQL CommandsSQL = new CommandsSQL();
        DBConnection DBConnection = new DBConnection();
        User user = new User();
        // GET: Authentication
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastro(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }
            
            //Criar tratamento para usuarios que ja existem

            User usuario = new User
            {

                Name = user.Name,
                Email = user.Email,
                Login = user.Login,
                Password = user.Password

            };

            CommandsSQL.Insert(user);

            return RedirectToAction("Index", "Home");
            
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login loginUser)
        {
            if (!ModelState.IsValid)
            {
                return View(loginUser);
            }


            //METODO ERRADO, UTILIZAR LISTAS PARA TRAZER RESULTADOS
            //if (CommandsSQL.LoginValidate(loginUser) == null)
            //{
            //    ModelState.AddModelError("User", "Usuário ou senha inválidos");
            //    return View(loginUser);
            //}

            return RedirectToAction("Index", "Home");
        }

    }
}
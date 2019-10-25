using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CadastroLogin.Models;
using CadastroLogin.Database;

namespace CadastroLogin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        //Terminar de configurar Authorize
        //[Authorize(Roles = "Adminstrador")]
        public ActionResult ListarAlunos(User user)
        {
            var RetornarAlunos = new CommandsSQL();
            var TodosUsuarios = RetornarAlunos.Listar();
            return View(TodosUsuarios);
        }


    }
}
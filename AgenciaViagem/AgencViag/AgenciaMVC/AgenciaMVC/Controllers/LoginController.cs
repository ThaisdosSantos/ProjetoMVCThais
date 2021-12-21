using AgenciaMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System;
using AgenciaMVC.Data;

namespace AgenciaMVC.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            ViewData["logins"] = dbcontext.Logins.Where(p => p.CodLogin > 0).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Login login )
        {
            var dbcontext = new Contexto();
            dbcontext.Add(login);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Deletar(Login login )
        {
            var dbcontext = new Contexto();

            var loginDelete = dbcontext.Logins.Find(login.CodLogin);
            dbcontext.Remove(loginDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(Login novosDadosLogin)
        {
            var dbcontext = new Contexto();

            var antigosDadosLogin = dbcontext.Logins.Find(novosDadosLogin.CodLogin );

            antigosDadosLogin.Email = novosDadosLogin.Email;
            antigosDadosLogin.Senha = novosDadosLogin.Senha;


            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
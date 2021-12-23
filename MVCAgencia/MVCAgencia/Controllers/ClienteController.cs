using Microsoft.AspNetCore.Mvc;
using MVCAgencia.Data;
using MVCAgencia.Models;
using System.Linq;

namespace MVCAgencia.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var dbcontext = new Contexto();

            ViewData["clientes"] = dbcontext.Clientes.Where(p => p.CodCliente > 0).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Cliente cliente)
        {
            var dbcontext = new Contexto();
            dbcontext.Add(cliente);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Deletar(Cliente cliente)
        {
            var dbcontext = new Contexto();

            var clienteDelete = dbcontext.Clientes.Find(cliente.CodCliente);
            dbcontext.Remove(clienteDelete);
            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Atualizar(Cliente novosDadosCliente)
        {
            var dbcontext = new Contexto();

            var antigosDadosCliente = dbcontext.Clientes.Find(novosDadosCliente.CodCliente);

            antigosDadosCliente.NomeCompleto = novosDadosCliente.NomeCompleto;
            antigosDadosCliente.CPF = novosDadosCliente.CPF;
            antigosDadosCliente.RG = novosDadosCliente.RG;
            antigosDadosCliente.Nascimento = novosDadosCliente.Nascimento;

            dbcontext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
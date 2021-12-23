using Microsoft.AspNetCore.Mvc;

namespace MVCAgencia.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

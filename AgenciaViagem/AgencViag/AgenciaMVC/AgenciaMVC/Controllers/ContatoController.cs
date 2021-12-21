using Microsoft.AspNetCore.Mvc;

namespace AgenciaMVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

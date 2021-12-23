using Microsoft.AspNetCore.Mvc;

namespace MVCAgencia.Controllers
{
    public class PromocaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

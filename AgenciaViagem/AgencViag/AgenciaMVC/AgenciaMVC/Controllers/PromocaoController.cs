using Microsoft.AspNetCore.Mvc;

namespace AgenciaMVC.Controllers
{
    public class PromocaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

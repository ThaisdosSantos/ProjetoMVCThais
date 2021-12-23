using Microsoft.AspNetCore.Mvc;

namespace MVCAgencia.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

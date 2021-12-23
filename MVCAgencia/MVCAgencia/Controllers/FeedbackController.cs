using Microsoft.AspNetCore.Mvc;

namespace MVCAgencia.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

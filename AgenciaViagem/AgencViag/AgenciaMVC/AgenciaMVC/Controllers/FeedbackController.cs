using Microsoft.AspNetCore.Mvc;

namespace AgenciaMVC.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

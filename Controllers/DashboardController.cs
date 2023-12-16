using Microsoft.AspNetCore.Mvc;

namespace MVC_TUTORIAL_5_12_23.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

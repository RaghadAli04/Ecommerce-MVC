using Microsoft.AspNetCore.Mvc;

namespace mvc_project.Areas.User.Controllers
{
[Area("User")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

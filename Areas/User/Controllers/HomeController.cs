using Microsoft.AspNetCore.Mvc;
using mvc_project.Areas.User.Data;
using mvc_project.Data;


namespace mvc_project.Areas.User.Controllers
{
[Area("User")]
    public class HomeController : Controller
    {
        ApplicationDbCotext context = new ApplicationDbCotext();
        public IActionResult Index()
        {
            var catagories = context.Catagories.ToList();
            return View(catagories);
        }
    }
}

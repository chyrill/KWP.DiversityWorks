using Microsoft.AspNetCore.Mvc;

namespace DiversityWorks.Members.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            return View();
        }
    }
}

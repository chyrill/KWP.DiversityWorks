
using Microsoft.AspNetCore.Mvc;

namespace DiversityWorks.TheAdmin.Recipe.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("/admin");
        }
    }
}

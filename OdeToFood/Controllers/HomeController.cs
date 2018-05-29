// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

using Microsoft.AspNetCore.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Content("HomeController");
        }
    }
}

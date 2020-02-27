using Microsoft.AspNetCore.Mvc;
using WebApp.DAL;
namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        protected ApplicationDbContext Context;
        public HomeController(ApplicationDbContext context)
        {
            Context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

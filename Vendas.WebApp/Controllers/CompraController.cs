using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vendas.WebApp.Service;
namespace Vendas.WebApp.Controllers
{
    public class CompraController : Controller
    {
        private readonly CompraService _CompraService;
        public CompraController(CompraService CompraService)
        {
            _CompraService = CompraService;
        }
        //Index - Sincrono
        public IActionResult Index()
        {
            Session();
            return View(_CompraService.FindAll());
        }
        public void Session()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            ViewBag.Message1 = HttpContext.Session.GetString("UserCargo");
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vendas.WebApp.Service;
namespace Vendas.WebApp.Controllers
{
    public class PedidoController : Controller
    {
        private readonly PedidoService _pedidoService;
        public PedidoController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }
        //Index - Sincrono
        public IActionResult Index()
        {
            Session();
            return View(_pedidoService.FindAll());
        }
        public void Session()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            ViewBag.Message1 = HttpContext.Session.GetString("UserCargo");
        }
    }
}

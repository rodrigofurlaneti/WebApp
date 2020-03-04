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
            return View(_pedidoService.FindAll());
        }
    }
}

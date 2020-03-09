using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vendas.Api.Service;

namespace Vendas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]

    public class PedidoController : Controller
    {
        private readonly PedidoService _PedidoService;
        public PedidoController(PedidoService PedidoService)
        {
            _PedidoService = PedidoService;
        }
        [HttpGet]
        public string Get()
        {
            var Pedido = _PedidoService.FindAll();
            string json = JsonConvert.SerializeObject(Pedido);
            return (json);
        }
    }
}

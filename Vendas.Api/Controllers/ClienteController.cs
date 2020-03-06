using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vendas.Api.Models;
using Vendas.Api.Service;
namespace Vendas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ClienteController : Controller
    {
        private readonly ClienteService _ClienteService;
        public ClienteController(ClienteService ClienteService)
        {
            _ClienteService = ClienteService;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var Cliente = _ClienteService.FindAll();
            string json = JsonConvert.SerializeObject(Cliente);
            return Json(json);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var Cliente = _ClienteService.FindById(id);
            string json = JsonConvert.SerializeObject(Cliente);
            return Json(json);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Create(Cliente Cliente)
        {
            _ClienteService.InsertAsync(Cliente);
            return RedirectToAction("Cliente", "Get");
        }

    }
}
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
    public class ComandaController : Controller
    {
        private readonly ComandaService _ComandaService;
        public ComandaController(ComandaService ComandaService)
        {
            _ComandaService = ComandaService;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var Comanda = _ComandaService.FindAll();
            string json = JsonConvert.SerializeObject(Comanda);
            return Json(json);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var Comanda = _ComandaService.FindById(id);
            string json = JsonConvert.SerializeObject(Comanda);
            return Json(json);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Create(Comanda Comanda)
        {
            _ComandaService.InsertAsync(Comanda);
            return RedirectToAction("Comanda", "Get");
        }

    }
}
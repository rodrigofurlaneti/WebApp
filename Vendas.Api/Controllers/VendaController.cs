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
    public class VendaController : Controller
    {
        private readonly VendaService _VendaService;
        public VendaController(VendaService VendaService)
        {
            _VendaService = VendaService;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var Venda = _VendaService.FindAll();
            string json = JsonConvert.SerializeObject(Venda);
            return Json(json);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var Venda = _VendaService.FindById(id);
            string json = JsonConvert.SerializeObject(Venda);
            return Json(json);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Create(Venda Venda)
        {
            _VendaService.InsertAsync(Venda);
            return RedirectToAction("Venda", "Get");
        }

    }
}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Collections.Generic;
using Vendas.Api.Models;
using Vendas.Api.Service;
namespace Vendas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class CargoController : Controller
    {
        private readonly CargoService _cargoService;
        public CargoController(CargoService cargoService)
        {
            _cargoService = cargoService;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var cargo = _cargoService.FindAll();
            string json = JsonConvert.SerializeObject(cargo);
            return Json(json);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var cargo = _cargoService.FindById(id);
            string json = JsonConvert.SerializeObject(cargo);
            return Json(json);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Create(Cargo cargo)
        {
            _cargoService.InsertAsync(cargo);
            return RedirectToAction("Cargo", "Get");
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vendas.Api.Models;
using Vendas.Api.Service;
namespace Vendas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        public ActionResult<Cargo> Post(Cargo cargo)
        {
            _cargoService.InsertAsync(cargo);
            return CreatedAtAction(nameof(Get), new { id = cargo.Id }, cargo);
        }
        [HttpDelete("{id}")]
        public ActionResult<Cargo> Delete(int id)
        {
             _cargoService.Remove(id);
            return CreatedAtAction(nameof(Get), new { id = id });

        }
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, Cargo cargo)
        //{
        //    if (id != cargo.Id)
        //    {
        //        return BadRequest();
        //    }
        //    try
        //    {
        //        await _cargoService.Update(cargo);
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        var cs = _cargoService.FindById(id);
        //        if (cs.Id == null)
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }
        //    return CreatedAtAction(nameof(Get), new { id = id });
        //}

    }
}
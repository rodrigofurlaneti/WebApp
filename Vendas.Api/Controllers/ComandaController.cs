using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vendas.Api.Models;
using Vendas.Api.Service;
namespace Vendas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        public ActionResult<Comanda> Post(Comanda Comanda)
        {
            _ComandaService.InsertAsync(Comanda);
            return CreatedAtAction(nameof(Get), new { id = Comanda.Id }, Comanda);
        }
        [HttpDelete("{id}")]
        public ActionResult<Comanda> Delete(int id)
        {
            _ComandaService.Remove(id);
            return CreatedAtAction(nameof(Get), new { id = id });

        }
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, Comanda Comanda)
        //{
        //    if (id != Comanda.Id)
        //    {
        //        return BadRequest();
        //    }
        //    try
        //    {
        //        await _ComandaService.Update(Comanda);
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        var cs = _ComandaService.FindById(id);
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
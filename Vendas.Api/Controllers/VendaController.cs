using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vendas.Api.Models;
using Vendas.Api.Service;
namespace Vendas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        public ActionResult<Venda> Post(Venda Venda)
        {
            _VendaService.InsertAsync(Venda);
            return CreatedAtAction(nameof(Get), new { id = Venda.Id }, Venda);
        }
        [HttpDelete("{id}")]
        public ActionResult<Venda> Delete(int id)
        {
            _VendaService.Remove(id);
            return CreatedAtAction(nameof(Get), new { id = id });

        }
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, Venda Venda)
        //{
        //    if (id != Venda.Id)
        //    {
        //        return BadRequest();
        //    }
        //    try
        //    {
        //        await _VendaService.Update(Venda);
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        var cs = _VendaService.FindById(id);
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
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vendas.Api.Models;
using Vendas.Api.Service;
namespace Vendas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
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
        public ActionResult<Cliente> Post(Cliente Cliente)
        {
            _ClienteService.InsertAsync(Cliente);
            return CreatedAtAction(nameof(Get), new { id = Cliente.Id }, Cliente);
        }
        [HttpDelete("{id}")]
        public ActionResult<Cliente> Delete(int id)
        {
            _ClienteService.Remove(id);
            return CreatedAtAction(nameof(Get), new { id = id });

        }
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, Cliente Cliente)
        //{
        //    if (id != Cliente.Id)
        //    {
        //        return BadRequest();
        //    }
        //    try
        //    {
        //        await _ClienteService.Update(Cliente);
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        var cs = _ClienteService.FindById(id);
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
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vendas.Api.Models;
using Vendas.Api.Service;
namespace Vendas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CategoriaController : Controller
    {
        private readonly CategoriaService _CategoriaService;
        public CategoriaController(CategoriaService CategoriaService)
        {
            _CategoriaService = CategoriaService;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var Categoria = _CategoriaService.FindAll();
            string json = JsonConvert.SerializeObject(Categoria);
            return Json(json);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var Categoria = _CategoriaService.FindById(id);
            string json = JsonConvert.SerializeObject(Categoria);
            return Json(json);
        }
        [HttpPost]
        public ActionResult<Categoria> Post(Categoria Categoria)
        {
            _CategoriaService.InsertAsync(Categoria);
            return CreatedAtAction(nameof(Get), new { id = Categoria.Id }, Categoria);
        }
        [HttpDelete("{id}")]
        public ActionResult<Categoria> Delete(int id)
        {
            _CategoriaService.Remove(id);
            return CreatedAtAction(nameof(Get), new { id = id });

        }
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, Categoria Categoria)
        //{
        //    if (id != Categoria.Id)
        //    {
        //        return BadRequest();
        //    }
        //    try
        //    {
        //        await _CategoriaService.Update(Categoria);
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        var cs = _CategoriaService.FindById(id);
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
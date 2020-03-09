using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vendas.Api.Models;
using Vendas.Api.Service;
namespace Vendas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProdutoController : Controller
    {
        private readonly ProdutoService _ProdutoService;
        public ProdutoController(ProdutoService ProdutoService)
        {
            _ProdutoService = ProdutoService;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var Produto = _ProdutoService.FindAll();
            string json = JsonConvert.SerializeObject(Produto);
            return Json(json);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var Produto = _ProdutoService.FindById(id);
            string json = JsonConvert.SerializeObject(Produto);
            return Json(json);
        }
        [HttpPost]
        public ActionResult<Produto> Post(Produto Produto)
        {
            _ProdutoService.InsertAsync(Produto);
            return CreatedAtAction(nameof(Get), new { id = Produto.Id }, Produto);
        }
        [HttpDelete("{id}")]
        public ActionResult<Produto> Delete(int id)
        {
            _ProdutoService.Remove(id);
            return CreatedAtAction(nameof(Get), new { id = id });

        }
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, Produto Produto)
        //{
        //    if (id != Produto.Id)
        //    {
        //        return BadRequest();
        //    }
        //    try
        //    {
        //        await _ProdutoService.Update(Produto);
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        var cs = _ProdutoService.FindById(id);
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
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vendas.Api.Models;
using Vendas.Api.Service;
namespace Vendas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class UsuarioController : Controller
    {
        private readonly UsuarioService _UsuarioService;
        public UsuarioController(UsuarioService UsuarioService)
        {
            _UsuarioService = UsuarioService;
        }

        [HttpGet]
        public JsonResult Get()
        {
            var Usuario = _UsuarioService.FindAll();
            string json = JsonConvert.SerializeObject(Usuario);
            return Json(json);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            var Usuario = _UsuarioService.FindById(id);
            string json = JsonConvert.SerializeObject(Usuario);
            return Json(json);
        }
        [HttpPost]
        public ActionResult<Usuario> Post(Usuario Usuario)
        {
            _UsuarioService.InsertAsync(Usuario);
            return CreatedAtAction(nameof(Get), new { id = Usuario.Id }, Usuario);
        }
        [HttpDelete("{id}")]
        public ActionResult<Usuario> Delete(int id)
        {
            _UsuarioService.Remove(id);
            return CreatedAtAction(nameof(Get), new { id = id });

        }
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, Usuario Usuario)
        //{
        //    if (id != Usuario.Id)
        //    {
        //        return BadRequest();
        //    }
        //    try
        //    {
        //        await _UsuarioService.Update(Usuario);
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        var cs = _UsuarioService.FindById(id);
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
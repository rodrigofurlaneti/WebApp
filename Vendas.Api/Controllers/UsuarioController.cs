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
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Create(Usuario Usuario)
        {
            _UsuarioService.InsertAsync(Usuario);
            return RedirectToAction("Usuario", "Get");
        }

    }
}
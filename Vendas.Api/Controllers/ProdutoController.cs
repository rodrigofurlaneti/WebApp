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
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Create(Produto Produto)
        {
            _ProdutoService.InsertAsync(Produto);
            return RedirectToAction("Produto", "Get");
        }

    }
}
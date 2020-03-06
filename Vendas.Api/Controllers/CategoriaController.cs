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
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Create(Categoria Categoria)
        {
            _CategoriaService.InsertAsync(Categoria);
            return RedirectToAction("Categoria", "Get");
        }

    }
}
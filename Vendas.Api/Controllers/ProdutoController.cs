using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vendas.Api.Models;
using Vendas.Api.Service;
using System;
namespace Vendas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ProdutoController
    {
        private readonly ProdutoService _ProdutoService;
        public ProdutoController(ProdutoService ProdutoService)
        {
            _ProdutoService = ProdutoService;
        }

        [HttpGet]
        public string Get()
        {
            var Produto = _ProdutoService.FindAll();
            string json = JsonConvert.SerializeObject(Produto);
            return (json);
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            var Produto = _ProdutoService.FindById(id);
            string json = JsonConvert.SerializeObject(Produto);
            return (json);
        }
        [HttpPost]
        public void Post(Produto produto)
        {
            _ProdutoService.InsertAsync(produto);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _ProdutoService.Remove(id);
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
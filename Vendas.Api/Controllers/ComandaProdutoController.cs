using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Vendas.Api.Service;
namespace Vendas.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ComandaProdutoController
    {
        private readonly ComandaProdutoService _ComandaProdutoService;
        public ComandaProdutoController(ComandaProdutoService ComandaProdutoService)
        {
            _ComandaProdutoService = ComandaProdutoService;
        }
        [HttpGet("{id}")]
        public string Get(int id)
        {
            var ComandaProduto = _ComandaProdutoService.ToListProdutos(id);
            string json = JsonConvert.SerializeObject(ComandaProduto);
            return (json);
        }
    }
}

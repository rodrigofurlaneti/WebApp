using Microsoft.AspNetCore.Mvc;
using Vendas.WebApp.Controllers.Exceptions;
using Vendas.WebApp.Models;
using Vendas.WebApp.Models.ViewModels;
using Vendas.WebApp.Service;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Vendas.WebApp.Controllers
{
    public class PagamentoController : Controller
    {
        private readonly PagamentoService _PagamentoService;
        private readonly ComandaService _ComandaService;
        private readonly ComandaProdutoService _ComandaProdutoService;
        public PagamentoController(PagamentoService PagamentoService, ComandaService ComandaService, ComandaProdutoService ComandaProdutoService)
        {
            _PagamentoService = PagamentoService;
            _ComandaService = ComandaService;
            _ComandaProdutoService = ComandaProdutoService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(ComandaProduto p)
        {
            int id = p.Id;
            var comandaproduto = _ComandaProdutoService.ToListProdutos(id);
            if (comandaproduto == null)
            {
                return NotFound();
            }
            return View(comandaproduto);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Vendas.WebApp.Controllers.Exceptions;
using Vendas.WebApp.Models;
using Vendas.WebApp.Models.ViewModels;
using Vendas.WebApp.Service;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Vendas.WebApp.Controllers
{
    public class PagamentoController : Controller
    {
        private readonly PagamentoService _PagamentoService;
        private readonly ComandaService _ComandaService;
        public PagamentoController(PagamentoService PagamentoService, ComandaService ComandaService)
        {
            _PagamentoService = PagamentoService;
            _ComandaService = ComandaService;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.MessageId = HttpContext.Session.GetString("UserId");
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            ViewBag.Message1 = HttpContext.Session.GetString("UserCargo");
            var comanda = await _ComandaService.FindAllAsync();
            var viewModel = new PagamentoFormViewModels { Comanda = comanda };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(Pagamento pagamento)
        {
            int comandaid = pagamento.ComandaId;
            var pagamentoservice = _PagamentoService.ToListProdutosComanda(comandaid);
            if (pagamentoservice == null)
            {
                return NotFound();
            }
            return View(pagamentoservice);
        }
        public IActionResult Edit(Pagamento pagamento)
        {
            return View();
        }
    }
}
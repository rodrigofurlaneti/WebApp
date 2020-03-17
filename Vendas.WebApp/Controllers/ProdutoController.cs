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
    public class ProdutoController : Controller
    {
        private readonly ProdutoService _ProdutoService;
        private readonly CategoriaService _CategoriaService;
        public ProdutoController(ProdutoService ProdutoService, CategoriaService CategoriaService)
        {
            _ProdutoService = ProdutoService;
            _CategoriaService = CategoriaService;
        }

        //Index - Assincrono
        public async Task<IActionResult> Index()
        {
            ViewBag.MessageId = HttpContext.Session.GetString("UserId");
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            ViewBag.Message1 = HttpContext.Session.GetString("UserCargo");
            return View(await _ProdutoService.FindAllAsync());
        }

        //Create - Assincrono
        public async Task<IActionResult> Create()
        {
            var categoria = await _CategoriaService.FindAllAsync();
            var viewModel = new ProdutoFormViewModels { Categoria = categoria };
            return View(viewModel);
        }

        //Create - Assincrono
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Produto Produto)
        {
            await _ProdutoService.InsertAsync(Produto);
            return RedirectToAction(nameof(Index));
        }

        //Details - Assincrono
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var produto = await _ProdutoService.FindByIdAsync(id.Value);
            if (produto == null)
            {
                return NotFound();
            }
            int codigocategoria = produto.CodigoCategoria;
            var categoriaObj = _CategoriaService.FindById(codigocategoria);
            ProdutoFormViewModels viewModel = new ProdutoFormViewModels
            {
                Produto = produto,
                CategoriaObj = categoriaObj
            };
            return View(viewModel);
        }

        //Delete - Assincrono
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var produto = await _ProdutoService.FindByIdAsync(id.Value);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _ProdutoService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //Edit - Assincrono
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var produto = await _ProdutoService.FindByIdAsync(id.Value);
            if (produto == null)
            {
                return NotFound();
            }
            List<Categoria> categoria = _CategoriaService.FindAll();
            ProdutoFormViewModels viewModel = new ProdutoFormViewModels
            {
                Produto = produto,
                Categoria = categoria
            };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }
            try
            {
                await _ProdutoService.Update(produto);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }
        }
    }
}
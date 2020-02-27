using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Controllers.Exceptions;
using WebApp.Models;
using WebApp.Models.ViewModels;
using WebApp.Service;
namespace WebApp.Controllers
{
    public class VendaProdutoController : Controller
    {
        private readonly VendaProdutoService _VendaProdutoService;
        private readonly ProdutoService _ProdutoService;
        public VendaProdutoController(VendaProdutoService VendaProdutoService, ProdutoService ProdutoService)
        {
            _VendaProdutoService = VendaProdutoService;
            _ProdutoService = ProdutoService;
        }
        //Index - Assincrono
        public async Task<IActionResult> Index()
        {
            return View(await _VendaProdutoService.FindAllAsync());
        }
        //Create - Assincrono
        public async Task<IActionResult> Create()
        {
            var produto = await _ProdutoService.FindAllAsync();
            var viewModel = new VendaProdutoFormViewModels { Produto = produto };
            return View(viewModel);
        }

        //Create - Assincrono
        public async Task<IActionResult> CreateAdd()
        {
            var produto = await _ProdutoService.FindAllAsync();
            var viewModel = new VendaProdutoFormViewModels { Produto = produto };
            return View(viewModel);
        }

        //Create - Assincrono
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(VendaProduto VendaProduto)
        {
            await _VendaProdutoService.InsertAsync(VendaProduto);
            return RedirectToAction(nameof(CreateAdd));
        }

        //Details - Assincrono
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var VendaProduto = await _VendaProdutoService.FindByIdAsync(id.Value);
            if (VendaProduto == null)
            {
                return NotFound();
            }
            return View(VendaProduto);
        }

        //Delete - Assincrono
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var VendaProduto = await _VendaProdutoService.FindByIdAsync(id.Value);
            if (VendaProduto == null)
            {
                return NotFound();
            }
            return View(VendaProduto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _VendaProdutoService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //Edit - Assincrono
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var VendaProduto = await _VendaProdutoService.FindByIdAsync(id.Value);
            if (VendaProduto == null)
            {
                return NotFound();
            }
            return View(VendaProduto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, VendaProduto VendaProduto)
        {
            if (id != VendaProduto.Id)
            {
                return BadRequest();
            }
            try
            {
                await _VendaProdutoService.Update(VendaProduto);
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
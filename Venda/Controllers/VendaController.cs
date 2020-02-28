using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Vendas.WebApp.Controllers.Exceptions;
using Vendas.WebApp.Models;
using Vendas.WebApp.Models.ViewModels;
using Vendas.WebApp.Service;
namespace Vendas.WebApp.Controllers
{
    public class VendaController : Controller
    {
        private readonly VendaService _vendaService;
        private readonly ComandaService _comandaService;
        public VendaController(VendaService vendaService, ComandaService comandaService)
        {
            _vendaService = vendaService;
            _comandaService = comandaService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _vendaService.FindAllAsync());
        }
        //Create - Assincrono
        public async Task<IActionResult> Create()
        {
            var comandas = await _comandaService.FindAllAsync();
            var viewModel = new VendaFormViewModels { Comandas = comandas };
            return View(viewModel);
        }
        //Create - Assincrono
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Venda venda)
        {
            venda.Data = DateTime.Now.ToString();
            await _vendaService.InsertAsync(venda);
            return RedirectToAction("Create", "VendaProduto", new { VendaId = venda.Id });
            //return RedirectToAction(nameof(Index));
        }

        //Details - Assincrono
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var venda = await _vendaService.FindByIdAsync(id.Value);
            if (venda == null)
            {
                return NotFound();
            }
            return View(venda);
        }

        //Delete - Assincrono
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var venda = await _vendaService.FindByIdAsync(id.Value);
            if (venda == null)
            {
                return NotFound();
            }
            return View(venda);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _vendaService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //Edit - Assincrono
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var venda = await _vendaService.FindByIdAsync(id.Value);
            if (venda == null)
            {
                return NotFound();
            }
            return View(venda);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Venda venda)
        {
            if (id != venda.Id)
            {
                return BadRequest();
            }
            try
            {
                await _vendaService.Update(venda);
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
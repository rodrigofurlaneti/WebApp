using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Vendas.WebApp.Controllers.Exceptions;
using Vendas.WebApp.Models;
using Vendas.WebApp.Models.ViewModels;
using Vendas.WebApp.Service;
namespace Vendas.WebApp.Controllers
{
    public class ComandaController : Controller
    {
        private readonly ComandaService _comandaService;
        private readonly ClienteService _clienteService;
        public ComandaController(ComandaService comandaService, ClienteService clienteService)
        {
            _comandaService = comandaService;
            _clienteService = clienteService;
        }
        //Index - Assincrono
        public async Task<IActionResult> Index()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            ViewBag.Message1 = HttpContext.Session.GetString("UserCargo");
            return View(await _comandaService.FindAllAsync());
        }
        //Create - Sincrono
        public async Task<IActionResult> Create()
        {
            var clientes = await _clienteService.FindAllAsync();
            var viewModel = new ComandaFormViewModels { Clientes = clientes };
            return View(viewModel);
        }

        //Create - Assincrono
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Comanda comanda)
        {
            comanda.Data = DateTime.Now.ToString();
            comanda.Status = "Aberta";
            await _comandaService.InsertAsync(comanda);
            return RedirectToAction(nameof(Index));
        }
        //Details - Assincrono
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var produto = await _comandaService.FindByIdAsync(id.Value);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        //Delete - Assincrono
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var comanda = await _comandaService.FindByIdAsync(id.Value);
            if (comanda == null)
            {
                return NotFound();
            }
            return View(comanda);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _comandaService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //Edit - Assincrono
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var comanda = await _comandaService.FindByIdAsync(id.Value);

            if (comanda == null)
            {
                return NotFound();
            }
            var clientes = await _clienteService.FindAllAsync();
            var viewModel = new ComandaFormViewModels { Comanda = comanda, Clientes = clientes };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Comanda comanda)
        {
            if (id != comanda.Id)
            {
                return BadRequest();
            }
            try
            {
                comanda.Data = DateTime.Now.ToString();
                await _comandaService.Update(comanda);
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

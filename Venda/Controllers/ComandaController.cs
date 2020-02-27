using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Vendas.WebApp.Controllers.Exceptions;
using Vendas.WebApp.Models;
using Vendas.WebApp.Service;
namespace Vendas.WebApp.Controllers
{
    public class ComandaController : Controller
    {
        private readonly ComandaService _comandaService;
        public ComandaController(ComandaService comandaService)
        {
            _comandaService = comandaService;
        }

        //Index - Assincrono
        public async Task<IActionResult> Index()
        {
            return View(await _comandaService.FindAllAsync());
        }

        //Create - Sincrono
        public IActionResult Create()
        {
            return View();
        }

        //Create - Assincrono
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Comanda comanda)
        {
            comanda.Data = DateTime.Now.ToString();
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
            var comanda = await _comandaService.FindByIdAsync(id.Value);
            if (comanda == null)
            {
                return NotFound();
            }
            return View(comanda);
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
            return View(comanda);
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

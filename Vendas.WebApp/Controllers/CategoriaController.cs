﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Vendas.WebApp.Controllers.Exceptions;
using Vendas.WebApp.Models;
using Vendas.WebApp.Service;
namespace Vendas.WebApp.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly CategoriaService _categoriaService;
        public CategoriaController(CategoriaService categoriaService)
        {
            _categoriaService = categoriaService;
        }
 
        //Index - Assincrono
        public async Task<IActionResult> Index()
        {
            Session();
            return View(await _categoriaService.FindAllAsync());
        }

        //Create - Sincrono
        public IActionResult Create()
        {
            return View();
        }

        //Create - Assincrono
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Categoria categoria)
        {
            await _categoriaService.InsertAsync(categoria);
            return RedirectToAction(nameof(Index));
        }

        //Details - Assincrono
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var categoria = await _categoriaService.FindByIdAsync(id.Value);
            if (categoria == null)
            {
                return NotFound();
            }
            return View(categoria);
        }

        //Delete - Assincrono
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var categoria = await _categoriaService.FindByIdAsync(id.Value);
            if (categoria == null)
            {
                return NotFound();
            }
            return View(categoria);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoriaService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //Edit - Assincrono
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var categoria = await _categoriaService.FindByIdAsync(id.Value);
            if (categoria == null)
            {
                return NotFound();
            }
            return View(categoria);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Categoria categoria)
        {
            if (id != categoria.Id)
            {
                return BadRequest();
            }
            try
            {
                await _categoriaService.Update(categoria);
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
        public void Session()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            ViewBag.Message1 = HttpContext.Session.GetString("UserCargo");
        }
    }
}
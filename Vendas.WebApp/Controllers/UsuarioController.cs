﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Vendas.WebApp.Controllers.Exceptions;
using Vendas.WebApp.Models;
using Vendas.WebApp.Models.ViewModels;
using Vendas.WebApp.Service;
namespace Vendas.WebApp.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly UsuarioService _usuarioService;
        private readonly CargoService _cargoService;
        public UsuarioController(UsuarioService usuarioService, CargoService cargoService)
        {
            _usuarioService = usuarioService;
            _cargoService = cargoService;
        }

        //Index - Assincrono
        public async Task<IActionResult> Index()
        {
            Session();
            return View(await _usuarioService.FindAllAsync());
        }

        //Create - Assincrono
        public async Task<IActionResult> Create()
        {
            Session();
            var cargo = await _cargoService.FindAllAsync();
            var viewModel = new UsuarioFormViewModels { Cargo = cargo };
            return View(viewModel);
        }

        //Create - Assincrono
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Usuario Usuario)
        {
            await _usuarioService.InsertAsync(Usuario);
            return RedirectToAction(nameof(Index));
        }

        //Details - Assincrono
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var usuario = await _usuarioService.FindByIdAsync(id.Value);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        //Delete - Assincrono
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var usuario = await _usuarioService.FindByIdAsync(id.Value);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _usuarioService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //Edit - Assincrono
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var usuario = await _usuarioService.FindByIdAsync(id.Value);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Usuario usuario)
        {
            if (id != usuario.Id)
            {
                return BadRequest();
            }
            try
            {
                await _usuarioService.Update(usuario);
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
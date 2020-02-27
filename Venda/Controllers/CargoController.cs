using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApp.Controllers.Exceptions;
using WebApp.Models;
using WebApp.Service;
namespace WebApp.Controllers
{
    public class CargoController : Controller
    {
        private readonly CargoService _cargoService;
        public CargoController(CargoService cargoService)
        {
            _cargoService = cargoService;
        }

        //Index - Assincrono
        public async Task<IActionResult> Index()
        {
            return View(await _cargoService.FindAllAsync());
        }

        //Create - Sincrono
        public IActionResult Create()
        {
            return View();
        }

        //Create - Assincrono
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Cargo cargo)
        {
            await _cargoService.InsertAsync(cargo);
            return RedirectToAction(nameof(Index));
        }

        //Details - Assincrono
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cargo = await _cargoService.FindByIdAsync(id.Value);
            if (cargo == null)
            {
                return NotFound();
            }
            return View(cargo);
        }

        //Delete - Assincrono
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Cargo = await _cargoService.FindByIdAsync(id.Value);
            if (Cargo == null)
            {
                return NotFound();
            }
            return View(Cargo);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _cargoService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        //Edit - Assincrono
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var Cargo = await _cargoService.FindByIdAsync(id.Value);
            if (Cargo == null)
            {
                return NotFound();
            }
            return View(Cargo);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Cargo Cargo)
        {
            if (id != Cargo.Id)
            {
                return BadRequest();
            }
            try
            {
                await _cargoService.Update(Cargo);
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
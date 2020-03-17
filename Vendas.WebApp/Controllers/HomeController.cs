using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Vendas.WebApp.Models;
using Vendas.WebApp.Service;
namespace Vendas.WebApp.Controllers
{
    public class HomeController : Controller
    {
        protected UsuarioService usuarioService;
        public HomeController(UsuarioService _usuarioService)
        {
            usuarioService = _usuarioService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult EditUser()
        {
            return View();
        }
        public IActionResult Details()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            ViewBag.Message1 = HttpContext.Session.GetString("UserCargo");
            return View();
        }
        //Create - Assincrono
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FindByUser(Usuario usuario)
        {
            string user = usuario.Nome;
            var userBank = usuarioService.FindByUser(user);
            if (userBank.Count > 0)
            {
                if (userBank[0].Senha == usuario.Senha)
                {
                    HttpContext.Session.SetString("UserName", userBank[0].Nome);
                    HttpContext.Session.SetString("UserCargo", userBank[0].NomeCargo);
                    return RedirectToAction(nameof(Details));
                }
                else
                {
                    return RedirectToAction(nameof(Edit));
                }
            }
            return RedirectToAction(nameof(EditUser));
        }
    }
}

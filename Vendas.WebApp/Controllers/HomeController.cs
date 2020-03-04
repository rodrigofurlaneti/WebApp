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
            return View();
        }
        //Create - Assincrono
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult FindByUser(Usuario usuario)
        {
            string user = usuario.Nome;
            var pass = usuarioService.FindByUser(user);
            if (pass.Count > 0)
            {
                if (pass[0].Senha == usuario.Senha)
                {
                    return RedirectToAction(nameof(Details));
                }else{
                    return RedirectToAction(nameof(Edit));
                }
            }
            return RedirectToAction(nameof(EditUser));
        }
    }
}

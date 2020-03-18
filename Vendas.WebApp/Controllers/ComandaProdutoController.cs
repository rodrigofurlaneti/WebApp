using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using Vendas.WebApp.Models;
using Vendas.WebApp.Service;
namespace Vendas.WebApp.Controllers
{
    public class ComandaProdutoController : Controller
    {
        private readonly ComandaProdutoService _comandaProdutoService;
        public ComandaProdutoController(ComandaProdutoService comandaProdutoService)
        {
            _comandaProdutoService = comandaProdutoService;
        }
        //Index - Assincrono
        public ActionResult Index()
        {
            Session();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Details(ComandaProduto p)
        {
            int id = p.Id;
            var comandaproduto = _comandaProdutoService.ToListProdutos(id);
            if (comandaproduto == null)
            {
                return NotFound();
            }
            return View(comandaproduto);
        }
        public void Session()
        {
            ViewBag.Message = HttpContext.Session.GetString("UserName");
            ViewBag.Message1 = HttpContext.Session.GetString("UserCargo");
        }
    }
}

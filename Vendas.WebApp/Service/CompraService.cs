using System.Collections.Generic;
using Vendas.WebApp.DAL;
using Vendas.WebApp.Models;
namespace Vendas.WebApp.Service
{
    public class CompraService
    {
        private CompraContext Compracontext;
        public CompraService(CompraContext _Compracontext)
        {
            Compracontext = _Compracontext;
        }
        public List<Compra> FindAll()
        {
            return Compracontext.FindAll();
        }
    }
}

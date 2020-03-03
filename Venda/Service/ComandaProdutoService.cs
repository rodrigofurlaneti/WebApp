using System.Collections.Generic;
using Vendas.WebApp.DAL;
using Vendas.WebApp.Models;
namespace Vendas.WebApp.Service
{
    public class ComandaProdutoService
    {
        private ComandaProdutoContext comandaProdutoContext;
        public ComandaProdutoService(ComandaProdutoContext _comandaProdutoContext)
        {
            comandaProdutoContext = _comandaProdutoContext;
        }
        public List<ComandaProduto> ToListProdutos(int id)
        {
            return comandaProdutoContext.ToListProdutos(id);
        }
    }
}

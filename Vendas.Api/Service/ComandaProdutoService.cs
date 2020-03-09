using System.Collections.Generic;
using Vendas.Api.DAL;
using Vendas.Api.Models;
namespace Vendas.Api.Service
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

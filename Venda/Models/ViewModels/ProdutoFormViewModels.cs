using System.Collections.Generic;
namespace Vendas.WebApp.Models.ViewModels
{
    public class ProdutoFormViewModels
    {
        public Produto Produto { get; set; }
        public Categoria CategoriaObj { get; set; }
        public List<Categoria> Categoria { get; set; }
    }
}

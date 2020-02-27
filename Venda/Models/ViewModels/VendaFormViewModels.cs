using System.Collections.Generic;
namespace Vendas.WebApp.Models.ViewModels
{
    public class VendaFormViewModels
    {
        public Venda Venda { get; set; }
        public Cliente Cliente { get; set; }
        public List<Cliente> Clientes { get; set; }
        public VendaProdutoFormViewModels VendaProdutoFormViewModels { get; set; }
    }
}

using System.Collections.Generic;
namespace Vendas.WebApp.Models.ViewModels
{
    public class PagamentoFormViewModels
    {
        public Pagamento Pagamento { get; set; }
        public List<Comanda> Comanda { get; set; }
        public List<ComandaProduto> ComandaProduto { get; set; }
    }
}

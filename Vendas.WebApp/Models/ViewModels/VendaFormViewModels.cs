using System.Collections.Generic;
namespace Vendas.WebApp.Models.ViewModels
{
    public class VendaFormViewModels
    {
        public Venda Venda { get; set; }
        public Comanda Comanda { get; set; }
        public List<Comanda> Comandas { get; set; }
    }
}

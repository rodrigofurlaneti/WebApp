using System.Collections.Generic;
namespace Vendas.WebApp.Models.ViewModels
{
    public class ComandaFormViewModels
    {
        public Comanda Comanda { get; set; }
        public Cliente Cliente { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}

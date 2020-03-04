using System.Collections.Generic;
using Vendas.WebApp.DAL;
using Vendas.WebApp.Models;
namespace Vendas.WebApp.Service
{
    public class PedidoService
    {
        private PedidoContext pedidocontext;
        public PedidoService(PedidoContext _pedidocontext)
        {
            pedidocontext = _pedidocontext;
        }
        public List<Pedido> FindAll()
        {
            return pedidocontext.ToList();
        }
    }
}

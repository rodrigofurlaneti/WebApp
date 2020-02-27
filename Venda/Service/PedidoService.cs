using System.Collections.Generic;
using WebApp.DAL;
using WebApp.Models;
namespace WebApp.Service
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

using System.Collections.Generic;
using Vendas.Api.DAL;
using Vendas.Api.Models;
namespace Vendas.Api.Service
{
    public class PedidoService
    {
        private PedidoContext PedidoContext;
        public PedidoService(PedidoContext _PedidoContext)
        {
            PedidoContext = _PedidoContext;
        }
        public List<Pedido> FindAll()
        {
            return PedidoContext.FindAll();
        }
    }
}

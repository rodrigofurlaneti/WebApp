﻿namespace Vendas.Api.Models
{
    public class Pedido
    {
        virtual public string Produto { get; set; }
        virtual public string Quantidade { get; set; }
        virtual public string Nome { get; set; }
        virtual public string Comanda { get; set; }
        virtual public string Data { get; set; }
    }
}

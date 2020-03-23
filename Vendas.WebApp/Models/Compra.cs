namespace Vendas.WebApp.Models
{
    public class Compra
    {
        public virtual string Produto { get; set; }
        public virtual int Quantidade { get; set; }
        public virtual int QuantidadeMinima { get; set; }
        public virtual string QuantidadeCompra { get; set; }
        public virtual string ValorCustoUnitario { get; set; }
        public virtual string ValorCustoTotal { get; set; }

    }
}
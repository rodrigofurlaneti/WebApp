namespace Vendas.WebApp.Models
{
    public class VendaProduto
    {
        public int Id { get; set; }
        public int VendaId { get; set; }
        public int ProdutoId { get; set; }
        virtual public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        virtual public Venda Venda { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
namespace Vendas.WebApp.Models
{
    public class Pagamento
    {
        [Key]
        public int Id { get; set; }
        public int ComandaId { get; set; }
        public decimal ValorTotal { get; set; }
        public string DataPagamento { get; set; }
        virtual public string Produto { get; set; }
        virtual public string Quantidade { get; set; }
        virtual public string Nome { get; set; }
        virtual public string Comanda { get; set; }
        virtual public string Valor { get; set; }
        virtual public string Data { get; set; }
    }
}

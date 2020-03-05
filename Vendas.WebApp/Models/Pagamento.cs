using System.ComponentModel.DataAnnotations;
namespace Vendas.WebApp.Models
{
    public class Pagamento
    {
        [Key]
        public int Id { get; set; }
        public int ComandaId { get; set; }
        public decimal ValorTotal { get; set; }
        public string Data { get; set; }
    }
}

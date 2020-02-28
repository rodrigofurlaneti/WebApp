using System.ComponentModel.DataAnnotations;
namespace Vendas.WebApp.Models
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }
        public string Data { get; set; }
        public int ComandaId { get; set; }
        virtual public Comanda Comanda { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
namespace Vendas.WebApp.Models
{
    public class Venda
    {
        [Key]
        public int Id { get; set; }
        public string Data { get; set; }
        public int ClienteId { get; set; }
        virtual public Cliente Cliente { get; set; }
    }
}

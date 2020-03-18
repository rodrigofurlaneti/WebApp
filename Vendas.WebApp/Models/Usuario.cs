using System.ComponentModel.DataAnnotations;
namespace Vendas.WebApp.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int IdCargo { get; set; }
        public string NomeCargo { get; set; }
    }
}

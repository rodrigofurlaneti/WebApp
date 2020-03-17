using System.ComponentModel.DataAnnotations;
namespace Vendas.WebApp.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome do usuário!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o e-mail do usuário!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe o senha do usuário!")]
        public string Senha { get; set; }
        public int IdCargo { get; set; }
        public virtual string NomeCargo { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
namespace Vendas.Api.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do cliente!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o cpf do cliente!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Informe o email do cliente!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o número do celular do cliente!")]
        public string Celular { get; set; }

    }
}

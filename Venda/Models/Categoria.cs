using System.ComponentModel.DataAnnotations;
namespace Vendas.WebApp.Models
{
    public class Categoria
    {
        [Key]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Informe o nome da categoria!")]
        public string Nome { get; set; }
    }
}

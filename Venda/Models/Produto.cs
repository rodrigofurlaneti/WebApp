using System;
using System.ComponentModel.DataAnnotations;
namespace WebApp.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do produto!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe a quantidade do produto!")]
        public int Quantidade { get; set; }

        [Required(ErrorMessage = "Informe o valor do produto!")]
        [Range(0.1, Double.PositiveInfinity)]
        public decimal Valor { get; set; }

        public int CodigoCategoria { get; set; }
    }
}

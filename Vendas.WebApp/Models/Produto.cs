using System;
using System.ComponentModel.DataAnnotations;
namespace Vendas.WebApp.Models
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do produto!")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe a quantidade do produto!")]
        public int Quantidade { get; set; }
        [Required(ErrorMessage = "Informe a quantidade mínima do produto!")]
        public int QuantidadeMinima { get; set; }
        [Required(ErrorMessage = "Informe o valor do produto!")]
        [Range(0.1, Double.PositiveInfinity)]
        public string Valor { get; set; }
        public int IdCategoria { get; set; }
        public string ValorCustoUnitario { get; set; }
        public string ValorCustoTotal { get; set; }
        public string ValorLucroUnitario { get; set; }
        public string ValorLucroTotal { get; set; }
        public string ValorBruto { get; set; }

    }
}

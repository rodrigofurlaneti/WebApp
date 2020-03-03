namespace Vendas.WebApp.Models
{
    public class ComandaProduto
    {
        virtual public int Id { get; set; }
        virtual public string Produto { get; set; }
        virtual public string Quantidade { get; set; }
        virtual public string Valor { get; set; }
        virtual public string DataHora { get; set; }
    }
}

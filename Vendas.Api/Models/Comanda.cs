namespace Vendas.Api.Models
{
    public class Comanda
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public string Data { get; set; }
        public string Status { get; set; }
    }
}

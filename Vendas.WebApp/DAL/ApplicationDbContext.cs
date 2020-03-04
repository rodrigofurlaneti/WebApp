using Microsoft.EntityFrameworkCore;
using Vendas.WebApp.Models;
namespace Vendas.WebApp.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Vendas.WebApp.Models.Venda> Venda { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<VendaProduto> VendaProduto { get; set; }
        public DbSet<Comanda> Comanda { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
    }
}
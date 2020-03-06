using Microsoft.EntityFrameworkCore;
using Vendas.Api.Models;
namespace Vendas.Api.DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Comanda> Comanda { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Venda> Venda { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
    }
}
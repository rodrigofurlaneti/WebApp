using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Api.DAL;
using Vendas.Api.Models;
namespace Vendas.Api.Service
{
    public class ProdutoService
    {
        private ApplicationDbContext context;
        public ProdutoService(ApplicationDbContext _context)
        {
            context = _context;
        }
        //Sincrono - FindAll()
        public List<Produto> FindAll()
        {
            return context.Produto.ToList();
        }
        //Sincrono - FindById(int id)
        public Produto FindById(int id)
        {
            return context.Produto.FirstOrDefault(o => o.Id == id);
        }
        //Sincrono - InsertAsync(Produto obj)
        public void InsertAsync(Produto obj)
        {
            context.Add(obj);
            context.SaveChangesAsync();
        }
    }
}

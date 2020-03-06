using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Api.DAL;
using Vendas.Api.Models;
namespace Vendas.Api.Service
{
    public class CategoriaService
    {
        private ApplicationDbContext context;
        public CategoriaService(ApplicationDbContext _context)
        {
            context = _context;
        }
        //Sincrono - FindAll()
        public List<Categoria> FindAll()
        {
            return context.Categoria.ToList();
        }
        //Sincrono - FindById(int id)
        public Categoria FindById(int id)
        {
            return context.Categoria.FirstOrDefault(o => o.Id == id);
        }
        //Sincrono - InsertAsync(Categoria obj)
        public void InsertAsync(Categoria obj)
        {
            context.Add(obj);
            context.SaveChangesAsync();
        }
    }
}

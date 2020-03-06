using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Api.DAL;
using Vendas.Api.Models;
namespace Vendas.Api.Service
{
    public class ComandaService
    {
        private ApplicationDbContext context;
        public ComandaService(ApplicationDbContext _context)
        {
            context = _context;
        }
        //Sincrono - FindAll()
        public List<Comanda> FindAll()
        {
            return context.Comanda.ToList();
        }
        //Sincrono - FindById(int id)
        public Comanda FindById(int id)
        {
            return context.Comanda.FirstOrDefault(o => o.Id == id);
        }
        //Sincrono - InsertAsync(Comanda obj)
        public void InsertAsync(Comanda obj)
        {
            context.Add(obj);
            context.SaveChangesAsync();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.Api.DAL;
using Vendas.Api.Models;
namespace Vendas.Api.Service
{
    public class VendaService
    {
        private ApplicationDbContext context;
        public VendaService(ApplicationDbContext _context)
        {
            context = _context;
        }
        //Sincrono - FindAll()
        public List<Venda> FindAll()
        {
            return context.Venda.ToList();
        }
        //Sincrono - FindById(int id)
        public Venda FindById(int id)
        {
            return context.Venda.FirstOrDefault(o => o.Id == id);
        }
        //Sincrono - InsertAsync(Venda obj)
        public void InsertAsync(Venda obj)
        {
            context.Add(obj);
            context.SaveChangesAsync();
        }
    }
}

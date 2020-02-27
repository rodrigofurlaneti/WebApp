using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.WebApp.Controllers.Exceptions;
using Vendas.WebApp.DAL;
using Vendas.WebApp.Models;
namespace Vendas.WebApp.Service
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

        //Sincrono - Dispose()
        public void Dispose()
        {
            context.Dispose();
        }
        public async Task<List<Venda>> FindAllAsync()
        {
            return await context.Venda.Include(x => x.Cliente).ToListAsync();
        }
        //Assincrono - FindAsync()
        public async Task<Venda> FindAsync()
        {
            return await context.Venda.FirstOrDefaultAsync();
        }
        //Assincrono - InsertAsync(Venda Venda)
        public async Task InsertAsync(Venda venda)
        {
            context.Add(venda);
            await context.SaveChangesAsync();
        }

        //Sincrono - FindById(int id)
        public Venda FindById(int id)
        {
            return context.Venda.FirstOrDefault(o => o.Id == id);
        }

        //Assincrono
        public async Task<Venda> FindByIdAsync(int id)
        {
            return await context.Venda.FirstOrDefaultAsync(o => o.Id == id);
        }

        //Assincrono
        public async Task RemoveAsync(int id)
        {
            var venda = await context.Venda.FindAsync(id);
            context.Venda.Remove(venda);
            await context.SaveChangesAsync();
        }

        //Assincrono
        public async Task Update(Venda venda)
        {
            bool hasAny = await context.Venda.AnyAsync(x => x.Id == venda.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                context.Update(venda);
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
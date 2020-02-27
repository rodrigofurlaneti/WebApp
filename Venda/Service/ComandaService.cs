using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.WebApp.DAL;
using Vendas.WebApp.Controllers.Exceptions;
using Vendas.WebApp.Models;
namespace Vendas.WebApp.Service
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

        //Sincrono - Dispose()
        public void Dispose()
        {
            context.Dispose();
        }

        //Assincrono - FindAllAsync()
        public async Task<List<Comanda>> FindAllAsync()
        {
            return await context.Comanda.ToListAsync();
        }

        //Assincrono - InsertAsync(Comanda obj)
        public async Task InsertAsync(Comanda obj)
        {
            context.Add(obj);
            await context.SaveChangesAsync();
        }

        //Sincrono - FindById(int id)
        public Comanda FindById(int id)
        {
            return context.Comanda.FirstOrDefault(o => o.Id == id);
        }

        //Assincrono
        public async Task<Comanda> FindByIdAsync(int id)
        {
            return await context.Comanda.FirstOrDefaultAsync(o => o.Id == id);
        }

        //Assincrono
        public async Task RemoveAsync(int id)
        {
            var obj = await context.Comanda.FindAsync(id);
            context.Comanda.Remove(obj);
            await context.SaveChangesAsync();
        }

        //Assincrono
        public async Task Update(Comanda obj)
        {
            bool hasAny = await context.Comanda.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                context.Update(obj);
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}

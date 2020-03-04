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
        public List<Vendas.WebApp.Models.Venda> FindAll()
        {
            return context.Venda.ToList();
        }

        //Sincrono - Dispose()
        public void Dispose()
        {
            context.Dispose();
        }
        public async Task<List<Vendas.WebApp.Models.Venda>> FindAllAsync()
        {
            return await context.Venda.Include(x => x.Comanda).Include(x => x.Comanda.Cliente).ToListAsync();
        }
        //Assincrono - FindAsync()
        public async Task<Vendas.WebApp.Models.Venda> FindAsync()
        {
            return await context.Venda.FirstOrDefaultAsync();
        }
        //Assincrono - InsertAsync(Venda Venda)
        public async Task InsertAsync(Vendas.WebApp.Models.Venda venda)
        {
            context.Add(venda);
            await context.SaveChangesAsync();
        }

        //Sincrono - FindById(int id)
        public Vendas.WebApp.Models.Venda FindById(int id)
        {
            return context.Venda.FirstOrDefault(o => o.Id == id);
        }

        //Assincrono
        public async Task<Vendas.WebApp.Models.Venda> FindByIdAsync(int id)
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
        public async Task Update(Vendas.WebApp.Models.Venda venda)
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
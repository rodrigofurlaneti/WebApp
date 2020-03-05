using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.WebApp.DAL;
using Vendas.WebApp.Controllers.Exceptions;
using Vendas.WebApp.Models;
namespace Vendas.WebApp.Service
{
    public class PagamentoService
    {
        private ApplicationDbContext context;
        public PagamentoService(ApplicationDbContext _context)
        {
            context = _context;
        }

        //Sincrono - FindAll()
        public List<Pagamento> FindAll()
        {
            return context.Pagamento.ToList();
        }

        //Sincrono - Dispose()
        public void Dispose()
        {
            context.Dispose();
        }

        //Assincrono - FindAllAsync()
        public async Task<List<Pagamento>> FindAllAsync()
        {
            return await context.Pagamento.ToListAsync();
        }

        //Assincrono - InsertAsync(Pagamento obj)
        public async Task InsertAsync(Pagamento obj)
        {
            context.Add(obj);
            await context.SaveChangesAsync();
        }

        //Sincrono - FindById(int id)
        public Pagamento FindById(int id)
        {
            return context.Pagamento.FirstOrDefault(o => o.Id == id);
        }

        //Assincrono
        public async Task<Pagamento> FindByIdAsync(int id)
        {
            return await context.Pagamento.FirstOrDefaultAsync(o => o.Id == id);
        }

        //Assincrono
        public async Task RemoveAsync(int id)
        {
            var obj = await context.Pagamento.FindAsync(id);
            context.Pagamento.Remove(obj);
            await context.SaveChangesAsync();
        }

        //Assincrono
        public async Task Update(Pagamento obj)
        {
            bool hasAny = await context.Pagamento.AnyAsync(x => x.Id == obj.Id);
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

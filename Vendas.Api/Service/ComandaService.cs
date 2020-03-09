using System.Collections.Generic;
using System.Linq;
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

        //Assincrono
        public void Remove(int id)
        {
            var obj = context.Comanda.Find(id);
            context.Comanda.Remove(obj);
            context.SaveChangesAsync();
        }
        ////Assincrono - FindAllAsync()
        //public async Task<List<Comanda>> FindAllAsync()
        //{
        //    return await context.Comanda.OrderBy(x => x.Nome).ToListAsync();
        //}

        ////Assincrono
        //public async Task<Comanda> FindByIdAsync(int id)
        //{
        //    return await context.Comanda.FirstOrDefaultAsync(o => o.Id == id);
        //}

        ////Assincrono
        //public async Task Update(Comanda obj)
        //{
        //    bool hasAny = await context.Comanda.AnyAsync(x => x.Id == obj.Id);
        //    if (!hasAny)
        //    {
        //        throw new NotFoundException("Id not found");
        //    }
        //    try
        //    {
        //        context.Update(obj);
        //        await context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException e)
        //    {
        //        throw new DbConcurrencyException(e.Message);
        //    }
        //}
    }
}

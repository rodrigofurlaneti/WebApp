using System.Collections.Generic;
using System.Linq;
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

        //Assincrono
        public void Remove(int id)
        {
            var obj = context.Venda.Find(id);
            context.Venda.Remove(obj);
            context.SaveChangesAsync();
        }
        ////Assincrono - FindAllAsync()
        //public async Task<List<Venda>> FindAllAsync()
        //{
        //    return await context.Venda.OrderBy(x => x.Nome).ToListAsync();
        //}

        ////Assincrono
        //public async Task<Venda> FindByIdAsync(int id)
        //{
        //    return await context.Venda.FirstOrDefaultAsync(o => o.Id == id);
        //}

        ////Assincrono
        //public async Task Update(Venda obj)
        //{
        //    bool hasAny = await context.Venda.AnyAsync(x => x.Id == obj.Id);
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

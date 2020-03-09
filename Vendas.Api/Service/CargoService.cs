using System.Collections.Generic;
using System.Linq;
using Vendas.Api.DAL;
using Vendas.Api.Models;
namespace Vendas.Api.Service
{
    public class CargoService
    {
        private ApplicationDbContext context;
        public CargoService(ApplicationDbContext _context)
        {
            context = _context;
        }
        //Sincrono - FindAll()
        public List<Cargo> FindAll()
        {
            return context.Cargo.ToList();
        }
        //Sincrono - FindById(int id)
        public Cargo FindById(int id)
        {
            return context.Cargo.FirstOrDefault(o => o.Id == id);
        }
        //Sincrono - InsertAsync(Cargo obj)
        public void InsertAsync(Cargo obj)
        {
            context.Add(obj);
            context.SaveChangesAsync();
        }

        //Assincrono
        public void Remove(int id)
        {
            var obj = context.Cargo.Find(id);
            context.Cargo.Remove(obj);
            context.SaveChangesAsync();
        }
        ////Assincrono - FindAllAsync()
        //public async Task<List<Cargo>> FindAllAsync()
        //{
        //    return await context.Cargo.OrderBy(x => x.Nome).ToListAsync();
        //}

        ////Assincrono
        //public async Task<Cargo> FindByIdAsync(int id)
        //{
        //    return await context.Cargo.FirstOrDefaultAsync(o => o.Id == id);
        //}

        ////Assincrono
        //public async Task Update(Cargo obj)
        //{
        //    bool hasAny = await context.Cargo.AnyAsync(x => x.Id == obj.Id);
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

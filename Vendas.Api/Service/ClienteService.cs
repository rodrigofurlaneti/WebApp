using System.Collections.Generic;
using System.Linq;
using Vendas.Api.DAL;
using Vendas.Api.Models;
namespace Vendas.Api.Service
{
    public class ClienteService
    {
        private ApplicationDbContext context;
        public ClienteService(ApplicationDbContext _context)
        {
            context = _context;
        }
        //Sincrono - FindAll()
        public List<Cliente> FindAll()
        {
            return context.Cliente.ToList();
        }
        //Sincrono - FindById(int id)
        public Cliente FindById(int id)
        {
            return context.Cliente.FirstOrDefault(o => o.Id == id);
        }
        //Sincrono - InsertAsync(Cliente obj)
        public void InsertAsync(Cliente obj)
        {
            context.Add(obj);
            context.SaveChangesAsync();
        }

        //Assincrono
        public void Remove(int id)
        {
            var obj = context.Cliente.Find(id);
            context.Cliente.Remove(obj);
            context.SaveChangesAsync();
        }
        ////Assincrono - FindAllAsync()
        //public async Task<List<Cliente>> FindAllAsync()
        //{
        //    return await context.Cliente.OrderBy(x => x.Nome).ToListAsync();
        //}

        ////Assincrono
        //public async Task<Cliente> FindByIdAsync(int id)
        //{
        //    return await context.Cliente.FirstOrDefaultAsync(o => o.Id == id);
        //}

        ////Assincrono
        //public async Task Update(Cliente obj)
        //{
        //    bool hasAny = await context.Cliente.AnyAsync(x => x.Id == obj.Id);
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

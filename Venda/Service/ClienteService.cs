using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Controllers.Exceptions;
using WebApp.DAL;
using WebApp.Models;
namespace WebApp.Service
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

        //Sincrono - Dispose()
        public void Dispose()
        {
            context.Dispose();
        }
        //Assincrono - FindAsync()
        public async Task<Cliente> FindAsync()
        {
            return await context.Cliente.FirstOrDefaultAsync();
        }
        public async Task<List<Cliente>> FindAllAsync()
        {
            return await context.Cliente.ToListAsync();
        }
        //Assincrono - InsertAsync(Cliente obj)
        public async Task InsertAsync(Cliente obj)
        {
            context.Add(obj);
            await context.SaveChangesAsync();
        }

        //Sincrono - FindById(int id)
        public Cliente FindById(int id)
        {
            return context.Cliente.FirstOrDefault(o => o.Id == id);
        }

        //Assincrono
        public async Task<Cliente> FindByIdAsync(int id)
        {
            return await context.Cliente.FirstOrDefaultAsync(o => o.Id == id);
        }

        //Assincrono
        public async Task RemoveAsync(int id)
        {
            var obj = await context.Cliente.FindAsync(id);
            context.Cliente.Remove(obj);
            await context.SaveChangesAsync();
        }

        //Assincrono
        public async Task Update(Cliente obj)
        {
            bool hasAny = await context.Cliente.AnyAsync(x => x.Id == obj.Id);
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

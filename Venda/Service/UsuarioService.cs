using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.WebApp.Controllers.Exceptions;
using Vendas.WebApp.DAL;
using Vendas.WebApp.Models;
namespace Vendas.WebApp.Service
{
    public class UsuarioService
    {
        private ApplicationDbContext context;
        public UsuarioService(ApplicationDbContext _context)
        {
            context = _context;
        }
        //Sincrono - FindAll()
        public List<Usuario> FindAll()
        {
            return context.Usuario.ToList();
        }

        //Sincrono - Dispose()
        public void Dispose()
        {
            context.Dispose();
        }

        //Assincrono - FindAllAsync()
        public async Task<List<Usuario>> FindAllAsync()
        {
            return await context.Usuario.OrderBy(x => x.Nome).ToListAsync();
        }

        //Assincrono - InsertAsync(Usuario obj)
        public async Task InsertAsync(Usuario obj)
        {
            context.Add(obj);
            await context.SaveChangesAsync();
        }

        //Sincrono - FindById(int id)
        public Usuario FindById(int id)
        {
            return context.Usuario.FirstOrDefault(o => o.Id == id);
        }

        //Assincrono
        public async Task<Usuario> FindByIdAsync(int id)
        {
            return await context.Usuario.FirstOrDefaultAsync(o => o.Id == id);
        }

        //Assincrono
        public async Task RemoveAsync(int id)
        {
            var obj = await context.Usuario.FindAsync(id);
            context.Usuario.Remove(obj);
            await context.SaveChangesAsync();
        }

        //Assincrono
        public async Task Update(Usuario obj)
        {
            bool hasAny = await context.Usuario.AnyAsync(x => x.Id == obj.Id);
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
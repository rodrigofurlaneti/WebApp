using System.Collections.Generic;
using System.Linq;
using Vendas.Api.DAL;
using Vendas.Api.Models;
namespace Vendas.Api.Service
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
        //Sincrono - FindById(int id)
        public Usuario FindById(int id)
        {
            return context.Usuario.FirstOrDefault(o => o.Id == id);
        }
        //Sincrono - InsertAsync(Usuario obj)
        public void InsertAsync(Usuario obj)
        {
            context.Add(obj);
            context.SaveChangesAsync();
        }

        //Assincrono
        public void Remove(int id)
        {
            var obj = context.Usuario.Find(id);
            context.Usuario.Remove(obj);
            context.SaveChangesAsync();
        }
        ////Assincrono - FindAllAsync()
        //public async Task<List<Usuario>> FindAllAsync()
        //{
        //    return await context.Usuario.OrderBy(x => x.Nome).ToListAsync();
        //}

        ////Assincrono
        //public async Task<Usuario> FindByIdAsync(int id)
        //{
        //    return await context.Usuario.FirstOrDefaultAsync(o => o.Id == id);
        //}

        ////Assincrono
        //public async Task Update(Usuario obj)
        //{
        //    bool hasAny = await context.Usuario.AnyAsync(x => x.Id == obj.Id);
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

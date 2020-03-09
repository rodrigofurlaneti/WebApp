using System.Collections.Generic;
using System.Linq;
using Vendas.Api.DAL;
using Vendas.Api.Models;
namespace Vendas.Api.Service
{
    public class CategoriaService
    {
        private ApplicationDbContext context;
        public CategoriaService(ApplicationDbContext _context)
        {
            context = _context;
        }
        //Sincrono - FindAll()
        public List<Categoria> FindAll()
        {
            return context.Categoria.ToList();
        }
        //Sincrono - FindById(int id)
        public Categoria FindById(int id)
        {
            return context.Categoria.FirstOrDefault(o => o.Id == id);
        }
        //Sincrono - InsertAsync(Categoria obj)
        public void InsertAsync(Categoria obj)
        {
            context.Add(obj);
            context.SaveChangesAsync();
        }

        //Assincrono
        public void Remove(int id)
        {
            var obj = context.Categoria.Find(id);
            context.Categoria.Remove(obj);
            context.SaveChangesAsync();
        }
        ////Assincrono - FindAllAsync()
        //public async Task<List<Categoria>> FindAllAsync()
        //{
        //    return await context.Categoria.OrderBy(x => x.Nome).ToListAsync();
        //}

        ////Assincrono
        //public async Task<Categoria> FindByIdAsync(int id)
        //{
        //    return await context.Categoria.FirstOrDefaultAsync(o => o.Id == id);
        //}

        ////Assincrono
        //public async Task Update(Categoria obj)
        //{
        //    bool hasAny = await context.Categoria.AnyAsync(x => x.Id == obj.Id);
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

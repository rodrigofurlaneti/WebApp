using System.Collections.Generic;
using System.Linq;
using Vendas.Api.DAL;
using Vendas.Api.Models;
namespace Vendas.Api.Service
{
    public class ProdutoService
    {
        private ApplicationDbContext context;
        public ProdutoService(ApplicationDbContext _context)
        {
            context = _context;
        }
        //Sincrono - FindAll()
        public List<Produto> FindAll()
        {
            return context.Produto.ToList();
        }
        //Sincrono - FindById(int id)
        public Produto FindById(int id)
        {
            return context.Produto.FirstOrDefault(o => o.Id == id);
        }
        //Sincrono - InsertAsync(Produto obj)
        public void InsertAsync(Produto obj)
        {
            context.Add(obj);
            context.SaveChangesAsync();
        }

        //Assincrono
        public void Remove(int id)
        {
            var obj = context.Produto.Find(id);
            context.Produto.Remove(obj);
            context.SaveChangesAsync();
        }
        ////Assincrono - FindAllAsync()
        //public async Task<List<Produto>> FindAllAsync()
        //{
        //    return await context.Produto.OrderBy(x => x.Nome).ToListAsync();
        //}

        ////Assincrono
        //public async Task<Produto> FindByIdAsync(int id)
        //{
        //    return await context.Produto.FirstOrDefaultAsync(o => o.Id == id);
        //}

        ////Assincrono
        //public async Task Update(Produto obj)
        //{
        //    bool hasAny = await context.Produto.AnyAsync(x => x.Id == obj.Id);
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

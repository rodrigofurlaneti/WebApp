using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Controllers.Exceptions;
using WebApp.DAL;
using WebApp.Models;

namespace WebApp.Service
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

        //Sincrono - Dispose()
        public void Dispose()
        {
            context.Dispose();
        }

        //Assincrono - FindAllAsync()
        public async Task<List<Produto>> FindAllAsync()
        {
            return await context.Produto.OrderBy(x => x.Nome).ToListAsync();
        }

        //Assincrono - InsertAsync(Produto obj)
        public async Task InsertAsync(Produto obj)
        {
            context.Add(obj);
            await context.SaveChangesAsync();
        }

        //Sincrono - FindById(int id)
        public Produto FindById(int id)
        {
            return context.Produto.FirstOrDefault(o => o.Id == id);
        }

        //Assincrono
        public async Task<Produto> FindByIdAsync(int id)
        {
            return await context.Produto.FirstOrDefaultAsync(o => o.Id == id);
        }

        //Assincrono
        public async Task RemoveAsync(int id)
        {
            var obj = await context.Produto.FindAsync(id);
            context.Produto.Remove(obj);
            await context.SaveChangesAsync();
        }

        //Assincrono
        public async Task Update(Produto obj)
        {
            bool hasAny = await context.Produto.AnyAsync(x => x.Id == obj.Id);
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

﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.WebApp.DAL;
using Vendas.WebApp.Controllers.Exceptions;
using Vendas.WebApp.Models;
namespace Vendas.WebApp.Service
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

        //Sincrono - Dispose()
        public void Dispose()
        {
            context.Dispose();
        }

        //Assincrono - FindAllAsync()
        public async Task<List<Categoria>> FindAllAsync()
        {
            return await context.Categoria.ToListAsync();
        }

        //Assincrono - InsertAsync(Categoria obj)
        public async Task InsertAsync(Categoria obj)
        {
            context.Add(obj);
            await context.SaveChangesAsync();
        }

        //Sincrono - FindById(int id)
        public Categoria FindById(int id)
        {
            return context.Categoria.FirstOrDefault(o => o.Id == id);
        }

        //Assincrono
        public async Task<Categoria> FindByIdAsync(int id)
        {
            return await context.Categoria.FirstOrDefaultAsync(o => o.Id == id);
        }

        //Assincrono
        public async Task RemoveAsync(int id)
        {
            var obj = await context.Categoria.FindAsync(id);
            context.Categoria.Remove(obj);
            await context.SaveChangesAsync();
        }

        //Assincrono
        public async Task Update(Categoria obj)
        {
            bool hasAny = await context.Categoria.AnyAsync(x => x.Id == obj.Id);
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

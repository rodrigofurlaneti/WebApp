﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.WebApp.DAL;
using Vendas.WebApp.Controllers.Exceptions;
using Vendas.WebApp.Models;
namespace Vendas.WebApp.Service
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

        //Sincrono - Dispose()
        public void Dispose()
        {
            context.Dispose();
        }

        //Assincrono - FindAllAsync()
        public async Task<List<Cargo>> FindAllAsync()
        {
            return await context.Cargo.OrderBy(x => x.Nome).ToListAsync();
        }

        //Assincrono - InsertAsync(Cargo obj)
        public async Task InsertAsync(Cargo obj)
        {
            context.Add(obj);
            await context.SaveChangesAsync();
        }

        //Sincrono - FindById(int id)
        public Cargo FindById(int id)
        {
            return context.Cargo.FirstOrDefault(o => o.Id == id);
        }

        //Assincrono
        public async Task<Cargo> FindByIdAsync(int id)
        {
            return await context.Cargo.FirstOrDefaultAsync(o => o.Id == id);
        }

        //Assincrono
        public async Task RemoveAsync(int id)
        {
            var obj = await context.Cargo.FindAsync(id);
            context.Cargo.Remove(obj);
            await context.SaveChangesAsync();
        }

        //Assincrono
        public async Task Update(Cargo obj)
        {
            bool hasAny = await context.Cargo.AnyAsync(x => x.Id == obj.Id);
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

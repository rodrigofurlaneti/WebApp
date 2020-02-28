using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vendas.WebApp.Controllers.Exceptions;
using Vendas.WebApp.DAL;
using Vendas.WebApp.Models;
namespace Vendas.WebApp.Service
{
    public class VendaProdutoService
    {
        private ApplicationDbContext context;
        private ProdutoContext produtocontext;
        public VendaProdutoService(ApplicationDbContext _context, ProdutoContext _produtocontext)
        {
            context = _context;
            produtocontext = _produtocontext;
        }

        //Sincrono - FindAll()
        public List<VendaProduto> FindAll()
        {
            return context.VendaProduto.ToList();
        }

        //Sincrono - Dispose()
        public void Dispose()
        {
            context.Dispose();
        }

        //Assincrono - FindAllAsync()
        public async Task<List<VendaProduto>> FindAllAsync()
        {
            return await context.VendaProduto.Include(x => x.Produto).ToListAsync();
        }

        //Assincrono - InsertAsync(Venda Venda)
        public async Task InsertAsync(VendaProduto vendaproduto)
        {
            context.Add(vendaproduto);
            int idProduto = vendaproduto.ProdutoId;
            int quantProdutoPedido = vendaproduto.Quantidade;
            produtocontext.DeleteProduto(idProduto, quantProdutoPedido);
            await context.SaveChangesAsync();
        }

        //Sincrono - FindById(int id)
        public VendaProduto FindById(int id)
        {
            return context.VendaProduto.FirstOrDefault(o => o.Id == id);
        }

        //Assincrono
        public async Task<VendaProduto> FindByIdAsync(int id)
        {
            return await context.VendaProduto.FirstOrDefaultAsync(o => o.Id == id);
        }

        //Assincrono
        public async Task RemoveAsync(int id)
        {
            var vendaproduto = await context.VendaProduto.FindAsync(id);
            context.VendaProduto.Remove(vendaproduto);
            await context.SaveChangesAsync();
        }

        //Assincrono
        public async Task Update(VendaProduto vendaproduto)
        {
            bool hasAny = await context.VendaProduto.AnyAsync(x => x.Id == vendaproduto.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                context.Update(vendaproduto);
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}

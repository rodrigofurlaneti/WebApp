using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}

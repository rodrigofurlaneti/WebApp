using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}

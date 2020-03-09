using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Vendas.Api.DAL;
using Vendas.Api.Service;
namespace Vendas.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(opitons => opitons.UseSqlServer("Server=.;Database=estoque;Trusted_Connection=True;MultipleActiveResultSets=true"));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<CargoService>();
            services.AddScoped<CategoriaService>();
            services.AddScoped<ClienteService>();
            services.AddScoped<ComandaService>();
            services.AddScoped<ProdutoService>();
            services.AddScoped<UsuarioService>();
            services.AddScoped<VendaService>();
            services.AddScoped<ComandaProdutoService>();
            services.AddScoped<ComandaProdutoContext>();
            services.AddScoped<PedidoService>();
            services.AddScoped<PedidoContext>();
        }
        public void Configure(IApplicationBuilder app, Microsoft.AspNetCore.Hosting.IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
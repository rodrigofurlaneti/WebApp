using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using Vendas.WebApp.DAL;
using Vendas.WebApp.Service;
namespace Vendas.WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        [System.Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDbContext<ApplicationDbContext>(opitons => opitons.UseSqlServer("Server=.;Database=estoque;Trusted_Connection=True;MultipleActiveResultSets=true"));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<CargoService>();
            services.AddScoped<CategoriaService>();
            services.AddScoped<ClienteService>();
            services.AddScoped<UsuarioService>();
            services.AddScoped<ProdutoService>();
            services.AddScoped<ProdutoContext>();
            services.AddScoped<VendaService>();
            services.AddScoped<VendaProdutoService>();
            services.AddScoped<PedidoService>();
            services.AddScoped<PedidoContext>();
            services.AddScoped<ComandaService>();
            services.AddScoped<ComandaProdutoService>();
            services.AddScoped<ComandaProdutoContext>();
            services.AddScoped<UsuarioContext>();
        }
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

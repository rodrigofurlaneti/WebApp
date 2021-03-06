﻿using Microsoft.AspNetCore.Builder;
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
            services.AddDbContext<ApplicationDbContext>(opitons => opitons.UseSqlServer("Server=.;Database=estoque;Trusted_Connection=True;MultipleActiveResultSets=true;"));
            //services.AddDbContext<ApplicationDbContext>(opitons => opitons.UseSqlServer("Server=47.254.54.175;Database=estoque;user Id=userbank;password=Mudar123;Trusted_Connection=False;MultipleActiveResultSets=true;"));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDistributedMemoryCache();
            services.AddSession();
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
            services.AddScoped<PagamentoService>();
            services.AddScoped<PagamentoContext>();
            services.AddScoped<ComandaProdutoService>();
            services.AddScoped<ComandaProdutoContext>();
            services.AddScoped<UsuarioContext>();
            services.AddScoped<CompraContext>();
            services.AddScoped<CompraService>();
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
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

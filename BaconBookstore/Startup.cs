using BaconBookstore.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaconBookstore
{
    public class Startup
    {

        // ADDED Creating the configuration
        public IConfiguration Configuration { get; set; }
        public Startup (IConfiguration temp)
        {
            Configuration = temp;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // ADDED Converting to an MVC project
            services.AddControllersWithViews();

            // ADDED Context from appsettings.json connection string
            services.AddDbContext<BookstoreContext>(options =>
           {
               options.UseSqlite(Configuration["ConnectionStrings:BookDBConnection"]);
           });

            // ADDED Repository for the DB
            // This decouples so that every HTTP request gets it's own repository
            services.AddScoped<IBookstoreRepository, EFBookStoreRepository>();
            services.AddScoped<IPurchaseRepository, EFPurchaseRepository>();

            // ADDED enable razor pages
            services.AddRazorPages();

            services.AddDistributedMemoryCache();
            services.AddSession();

            // ADDED adding session baskets
            services.AddScoped<Basket>(x => SessionBasket.GetBasket(x));
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // ADDED Use files in the wwwroot folder
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                // ADDED Use pagination endpoints with category included (Must come before other endpoints)
                endpoints.MapControllerRoute(
                    name: "categorypage", //what we're calling the endpoint, not necessarily the name of anything elsewhere
                    pattern: "{bookType}/Page{pageNum}", //this is the exact name of what is used in your controller
                    defaults: new { Controller = "Home", Action = "Index" }
                    );

                // ADDED Use pagination endpoints (Must come before other endpoints)
                // notice we don't need "name, pattern, and defaults")
                endpoints.MapControllerRoute(
                    "Paging", //what we're calling the endpoint, not necessarily the name of anything elsewhere
                    "Page{pageNum}", //this is the exact name of what is used in your controller
                    new { Controller = "Home", Action = "Index", pageNum = 1 }
                    );

                endpoints.MapControllerRoute("category", "{bookType}", new { Controller = "Home", Action = "Index", pageNum = 1 });

                

                // ADDED Use controller for endpoints
                endpoints.MapDefaultControllerRoute();

                // ADDED 
                endpoints.MapRazorPages();
            });
        }
    }
}

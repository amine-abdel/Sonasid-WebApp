using BookStore.Models.Repo;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MVC_SONASID.Models;
using MVC_SONASID.Models.Repo;
using Sonacid.Models;
using Sonacid.Models.Rep;

namespace Sonacid
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IMasse_Lineique_Repo<Masse_Lineique_I>, Masse_Lineique_IDbRepo>();
          

            services.AddScoped<IMasse_Lineique_Repo<Masse_Lineique_II>, Masse_Lineique_IIDbRepo>();
           
            services.AddScoped<IMasse_Lineique_Repo<H_V>, H_V_DbRepo>();

            services.AddSingleton<IMasse_Lineique_Repo<FARDEAUX>, FARDEAUXRepo>();

            services.AddSingleton<IMasse_Lineique_Repo<COURONNES>, COURONNESRepo>();
            services.AddDbContext<SonacidDbContext>(options=> 
            {
                options.UseSqlServer(Configuration.GetConnectionString("SqlDb"));
            });
           
            services.AddControllersWithViews();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

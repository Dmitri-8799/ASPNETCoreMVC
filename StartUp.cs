using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
 
namespace AreasApp
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
            services.AddControllersWithViews();
        }
 
        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
             
            app.UseRouting();
 
            app.UseEndpoints(endpoints =>
            {


/*
Метод MapAreaControllerRoute() принимает три обязательных параметра:
имя маршрута, имя области (areaName) и шаблон маршрута. 
Причем шаблон маршрута начинается с названия области: "store/{controller=Home}/{action=Index}/{id?}"

*/

              
                endpoints.MapControllerRoute(
                    name: "MyArea",
                  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}



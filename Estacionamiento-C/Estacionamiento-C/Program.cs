using Estacionamiento_C.Data;
using Estacionamiento_C.Models;
using Estacionamiento_C.TestsEnClase;
using Microsoft.EntityFrameworkCore;

namespace Estacionamiento_C
{
    public class Program
    {
        public static void Main(string[] args)
        {            
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.
                AddDbContext<EstacionamientoContext>(options => options.UseInMemoryDatabase("MiContexto"));


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }



    }
}
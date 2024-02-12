using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyCompany.Domain;
using MyCompany.Service;

internal class Program
{ /*IConfiguration Configuration { get; }*/
    private static void Main(string[] args)
    {


        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration.Bind("Project", new Config());
        builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));
        //    builder.Services.AddDbContext<AppDbContext>(options =>
        //options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

        // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddControllersWithViews();


        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();

        // подключаем поддержку статичных файлов в приложении (css, js и т.д.)
        app.UseStaticFiles();
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");
        app.Run();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();

        app.Run();
        app.UseEndpoints(endpoints =>
        {
            // создали маршрут администратора
            endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
            endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
        });
    }   }


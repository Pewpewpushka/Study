using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyCompany.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MyCompany.Domain.Repositories.Abstract;
using MyCompany.Domain.Repositories.EntityFramework;
using MyCompany.Domain;

namespace MyCompany
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)=>Configuration= configuration;
        public void ConfigureServices(IServiceCollection services)
        {   //подключаем конфиг из appsetting.json
            Configuration.Bind("Project", new Config());
            // подключаем нужный функционал приложения в качестве сервисов 
            services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();// если захотим сменить entity то здесь меняем занчение например меняем БД не микрософт а др
            services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
            services.AddTransient<DataManager>();// делаем транзиетными- пр запросе создается несколько объектов
            // подключаем контекст БД
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));// в качестве строки подключ. используем из файла appsettings.json

            //настраиваем identity систему
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;// минимальная длина для пароля
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;// Использовать только цифры
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //services.AddRazorPages();
            //настраиваем политику авторизации для Admin area
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });

            //добавляем сервисы для контроллеров и представлений (MVC)
            services.AddControllersWithViews(x =>
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
            })
                //выставляем совместимость с asp.net core 3.0
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }
        // порядок регистрации middlaware очень важен
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {      //в процессе разработки нам важно видеть какие именно ошибки
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            //if (env.IsDevelopment()) 
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //    app.UseExceptionHandler("/Error");

            //    app.UseHsts();
            //}

            app.UseHttpsRedirection();
            //подключаем поддержку статичных файлов
            app.UseStaticFiles();
            // подключаем систему маршуртизации
            app.UseRouting();
            // подключаем уатинфикацию и авторизацию
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseAuthorization();
            //реистрируем нужные нам маршруты
            app.UseEndpoints(endpoints =>
            {
                // создали маршрут администратора
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany
{
    public class Startup
    {
        //public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            //добавляем подержку контроллеров и представлений (mvc)
            services.AddControllersWithViews()
            //
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

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
            app.UseRouting();
            //подключаем поддержку статичных файлов
            app.UseStaticFiles();


            app.UseAuthorization();
            //реистрируем нужные нам маршруты
            app.UseEndpoints(endpoints =>
            {
                
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

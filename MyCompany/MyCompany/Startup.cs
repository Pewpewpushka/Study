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

namespace MyCompany
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)=>Configuration= configuration;
        public void ConfigureServices(IServiceCollection services)
        {   //���������� ������ �� appsetting.json
            Configuration.Bind("Project", new Config());
            //services.AddRazorPages();
            //��������� �������� ������������ � ������������� (mvc)
            services.AddControllersWithViews()
            //
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {      //� �������� ���������� ��� ����� ������ ����� ������ ������
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
            //���������� ��������� ��������� ������
            app.UseStaticFiles();


            app.UseAuthorization();
            //����������� ������ ��� ��������
            app.UseEndpoints(endpoints =>
            {
                
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

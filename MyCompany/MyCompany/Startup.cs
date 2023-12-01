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
        {   //���������� ������ �� appsetting.json
            Configuration.Bind("Project", new Config());
            // ���������� ������ ���������� ���������� � �������� �������� 
            services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();// ���� ������� ������� entity �� ����� ������ �������� �������� ������ �� �� ��������� � ��
            services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
            services.AddTransient<DataManager>();// ������ ������������- �� ������� ��������� ��������� ��������
            // ���������� �������� ��
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));// � �������� ������ �������. ���������� �� ����� appsettings.json

            //����������� identity �������
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;// ����������� ����� ��� ������
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuideApp.Web.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GuideApp.Web
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
            services.AddMvc();
            services.AddDbContext<GuideAppContext>(options => options.UseSqlServer(connectionString: Configuration.GetConnectionString("GuideApp")));
            services.AddDistributedRedisCache(options =>
            {
                options.Configuration = "localhost:6379";
                options.InstanceName = "GuideApp";
            });


            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("GuideApp", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "Swagger on Asp.Net Core",
                    Version = "1.0.0",
                    Description = "Simple Guide App",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact()
                    {
                        Name = "Swagger implemantation Yasin Kaya",
                        Url = new Uri("http://www.yasinkaya.org"),
                        Email = "iamyasinkaya@gmail.com"
                    },
                    TermsOfService = new Uri("http://swagger.io/terms/")
                });
            });
        }

     
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

            app.UseSwagger();
            app.UseSwaggerUI(option =>
            {
                option.SwaggerEndpoint("/swagger/GuideApp/swagger.json", "Swagger Guide App .Net Core");
            });

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

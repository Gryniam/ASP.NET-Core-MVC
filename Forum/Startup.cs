using Forum.Data;
using Forum.Data.EFramework;
using Forum.Data.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum
{
    public class Startup
    {
        private IConfigurationRoot _configString;

        [Obsolete]
        public Startup(Microsoft.AspNetCore.Hosting.IHostingEnvironment hostEnv)
        {
            _configString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_configString.GetConnectionString("DefaultConnection")));

            services.AddTransient<IUser, EFUser>();
            services.AddTransient<ITopicType, EFTopicType>();
            services.AddTransient<ITopic, EFTopic>();
            services.AddTransient<IStatus, EFStatus>();
            services.AddTransient<IRole, EFRole>();
            services.AddTransient<IComment, EFComment>();
            services.AddTransient<ICategory, EFCategory>();
            services.AddTransient<IBanStatus, EFBanStatus>();
            services.AddTransient<IAnswer, EFAnswer>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddScoped(sp=> )


            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // app.UseMvc();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseCookiePolicy();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });




            //app.UseHttpsRedirection();
            //app.UseStaticFiles();
            //app.UseRouting();
            //app.UseAuthorization();

           
        }
    }
}

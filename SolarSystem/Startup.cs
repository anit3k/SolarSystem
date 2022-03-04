using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SolarSystem.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarSystem
{
    public class Startup
    {
        #region fields
        private IConfiguration _configuration;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor the read the appsettings.json file
        /// used to get the connection string
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        #endregion

        #region Methods
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // one of the services that comes in the EF Core Nuget package, basically this is how we map the 
            // context class into EF and set the connection string read from appsettings.json file
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));


            // Implement the use of controllers in mvc and is part of
            // the MvcServiceColletion
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            CheckIsDevEnviroment(app, env);

            // this method makes the application search for static files in the "wwwroot" folder
            // used images etc.
            app.UseStaticFiles();

            /// UseRouting and UseEndpoint basically enables MVC to respond to incoming request
            /// In the UseEndpoint we can configure how MVC should read the routing
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        /// <summary>
        /// This method is use to get detail exception page, used only in
        /// development mode
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        private static void CheckIsDevEnviroment(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
        }
        #endregion

        #region Properties
        public IConfiguration Configuration
        {
            get { return _configuration; }
            set { _configuration = value; }
        }
        #endregion
    }
}

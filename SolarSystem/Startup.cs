using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SolarSystem.Dal;
using SolarSystem.Hubs;
using SolarSystem.Services;
using System.Globalization;
using System.Linq;

namespace SolarSystem
{
    public class Startup
    {
        #region fields
        private IConfiguration _configuration;
        private IWebHostEnvironment CurrentEnvironment { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor the read the appsettings.json file
        /// used to get the connection string
        /// </summary>
        /// <param name="configuration"></param>
        public Startup(IConfiguration configuration, IWebHostEnvironment currentEnviroment)
        {
            Configuration = configuration;
            CurrentEnvironment = currentEnviroment;
        }
        #endregion

        #region Methods
        // This method gets called by the runtime. Use this method to add services to the MVC container.
        public void ConfigureServices(IServiceCollection services)
        {
            // .AddScoped -> Scooped lifetime services are created once per Http request. but uses the same instance in other calls within the same web request
            // This will add language and localization to be used every where in the application, the services uses the repository pattern.
            if (CurrentEnvironment.EnvironmentName == "DevelopmentDb") // if debug profile is set to Iss Express with Db
            {
                services.AddScoped<ILanguageService, LanguageService>();
                services.AddScoped<ILocalizationService, LocalizationService>();
                services.AddScoped<IPlanetService, PlanetService>();
            }
            else // else run with mock-ups of the language and localization classes (normal debug - Iss Express and others)
            {
                // mock-up version of the above
                services.AddScoped<ILanguageService, MockLanguageService>();
                services.AddScoped<ILocalizationService, MockLocalizationService>();
                services.AddScoped<IPlanetService, MockPlanetService>();
            }            

            // one of the services that comes in the EF Core Nuget package, basically this is how we map the 
            // context class into EF and set the connection string read from appsettings.json file
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            // implements the build-in localization service in MVC
            services.AddLocalization();

            // Implement the use of controllers in mvc and is part of
            // the MvcServiceColletion
            services.AddControllersWithViews()
                        .AddViewLocalization(); // this service allow us to use @Localization syntax in the view

            // Here we make a new reference to a service provider, that we use to get the cultureInfo (supported language)
            var serviceProvider = services.BuildServiceProvider();
            var languageService = serviceProvider.GetRequiredService<ILanguageService>();
            var languages = languageService.GetLanguages();
            var cultures = languages.Select(x => new CultureInfo(x.Culture)).ToArray();
            // and here we configure the the culture info
            services.Configure<RequestLocalizationOptions>(options =>
            {
                // sets the default culture
                var englishCulture = cultures.FirstOrDefault(x => x.Name == "en-US");
                options.DefaultRequestCulture = new RequestCulture(englishCulture?.Name ?? "en-US");

                // adds an array of supported cultures.
                options.SupportedCultures = cultures;
                options.SupportedUICultures = cultures;
            });


            // Here we add the service for using SignalR, in this case we use it for an external client (Arduino and winform) to change the current url
            // to show selected planet
            services.AddSignalR(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // this method is called so that we can use the languageService and the localizationService
            app.UseRequestLocalization();

            // Used to write detailed exception page if run in Dev environment
            CheckIsDevEnviroment(app, env);


            // this method makes the application search for static files in the "wwwroot" folder
            // used images etc.
            app.UseStaticFiles();

            /// UseRouting and UseEndpoint basically enables MVC to respond to incoming request
            /// In the UseEndpoint we can configure how MVC should read the routing
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                // default route configuration
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                // this maps the route used for the signalR hub
                endpoints.MapHub<PlanetSelecterHub>("/PlanetSelecterHub");
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

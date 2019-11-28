using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BlazorLogin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace BlazorLogin
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Models.PalmDb.PalmDBaseContext>(options =>
             options.UseNpgsql(Configuration.GetConnectionString("PalmDbConnection")));

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(cookieOptions => {
                cookieOptions.LoginPath = "/Account/Login";
            });

            services.AddRazorPages()
                    .AddRazorPagesOptions(options =>
                    {
                        options.Conventions.AllowAnonymousToPage("/Account/Login");
                        options.Conventions.AuthorizeFolder("/Main");
                    });

            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();
            //services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();

            //services.AddMvc().AddRazorPagesOptions(options =>
            //{
            //    options.Conventions.AddPageRoute("/Account/Login", "");
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}

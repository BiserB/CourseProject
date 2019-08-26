using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vote.App.Areas.Identity.Services;
using Vote.App.Infrastructure.Extensions;
using Vote.App.Infrastructure.Filters;
using Vote.App.Infrastructure.Hubs;
using Vote.Data;
using Vote.Entities;
using Vote.Services.Manager;
using Vote.Services.Manager.Interfaces;
using Vote.Services.Manager.MapperProfile;
using Vote.Services.Participant;
using Vote.Services.Participant.Interfaces;
using Vote.Services.Participant.MapperProfile;

namespace Vote.App
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                options.Cookie.HttpOnly = true;
            });

            services.AddDbContext<VoteDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddAuthentication()
                    .AddCookie()
                    .AddFacebook(options =>
                    {
                        options.AppId = Configuration.GetSection("ExternalAuth:Facebook:AppId").Value;
                        options.AppSecret = Configuration.GetSection("ExternalAuth:Facebook:AppSecret").Value;
                    })
                    .AddGoogle(options =>
                    {
                        options.ClientId = Configuration.GetSection("ExternalAuth:Google:ClientId").Value;
                        options.ClientSecret = Configuration.GetSection("ExternalAuth:Google:ClientSecret").Value;
                    });

            services
               .AddIdentity<User, IdentityRole>()
               .AddDefaultUI()
               .AddDefaultTokenProviders()
               .AddEntityFrameworkStores<VoteDbContext>();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password = new PasswordOptions()
                {
                    RequiredLength = 4,
                    RequiredUniqueChars = 1,
                    RequireDigit = false,
                    RequireLowercase = true,
                    RequireNonAlphanumeric = false,
                    RequireUppercase = false
                };
            });

            services.AddSingleton<IEmailSender, SendGridEmailSender>();

            services.AddAutoMapper(options =>
            {
                options.AddProfile<ManagerAutoMapperProfile>();
                options.AddProfile<ParticipantAutoMapperProfile>();
            });

            services.Configure<RouteOptions>(options => options.LowercaseUrls = true);

            services.AddSignalR();

            RegisterServiceLayer(services);
            
            //services.AddSingleton<IHostingEnvironment>(new HostingEnvironment());

            services.AddMvc(options =>
            {
                options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
                options.Filters.Add<ExceptionHandlerFilter>();
            })
            .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.InitialDbSeed();
                //app.TestDataSeed();
            }
            else
            {
                app.UseExceptionHandler("/Main/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseCookiePolicy();

            app.UseSession();

            app.UseAuthentication();

            app.UseSignalR(routes =>
            {
                routes.MapHub<VoteHub>("/questions");
            });

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "main",
                    template: "{area=Main}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "all",
                    template: "{*url}",
                    defaults: new {area="Main", controller="Home", action="Index" });
            });
        }

        private static void RegisterServiceLayer(IServiceCollection services)
        {
            services.AddScoped<IParticipantEventsService, ParticipantEventsService>();

            services.AddScoped<IParticipantPollsService, ParticipantPollsService>();

            services.AddScoped<IManagerActivitiesService, ManagerActivitiesService>();

            services.AddScoped<IManagerSettingsService, ManagerSettingsService>();

            services.AddScoped<IManagerPollsService, ManagerPollsService>();

            services.AddScoped<IManagerQuestionsService, ManagerQuestionsService>();

            services.AddScoped<IParticipantRepliesService, ParticipantRepliesService>();            
        }
    }
}
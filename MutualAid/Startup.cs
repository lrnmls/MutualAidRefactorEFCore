using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MutualAid.Application.Interfaces;
using MutualAid.Application.Services;
using MutualAid.Data.Context;
using MutualAid.Data.Interfaces;
using MutualAid.Data.Repositories;
using MutualAid.UI.Interfaces;
using MutualAid.UI.Services;

namespace MutualAid.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            _environment = environment;
        }

        public IConfiguration Configuration { get; }

        private IWebHostEnvironment _environment;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureDatabases(services);

            ConfigureApplicationServices(services);
            ConfigureRepositories(services);
            ConfigureViewServices(services);

            services.AddControllersWithViews();

            services.AddAutoMapper(typeof(Startup), typeof(Application.MappingProfiles.UserMappingProfile));
            services.AddAutoMapper(typeof(Startup), typeof(UI.MappingProfiles.UserMappingProfile));
            services.AddAutoMapper(typeof(Startup), typeof(Application.MappingProfiles.RequestMappingProfile));
            services.AddAutoMapper(typeof(Startup), typeof(UI.MappingProfiles.RequestMappingProfile));
            services.AddAutoMapper(typeof(Startup), typeof(Application.MappingProfiles.AcceptedRequestMappingProfile));
            services.AddAutoMapper(typeof(Startup), typeof(UI.MappingProfiles.AcceptedRequestMappingProfile));

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(20);
                options.Cookie.HttpOnly = true;
            });

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        private void ConfigureRepositories(IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAuthRepository, AuthRepository>();
            services.AddScoped<IRequestRepository, RequestRepository>();
            services.AddScoped<IAcceptedRequestRepository, AcceptedRequestRepository>();
        }

        private void ConfigureViewServices(IServiceCollection services)
        {
            services.AddScoped<IUserViewService, UserViewService>();
            services.AddScoped<IRequestViewService, RequestViewService>();
            services.AddScoped<IAcceptedRequestViewService, AcceptedRequestViewService>();
            services.AddScoped<IAuthViewService, AuthViewService>();
        }

        private void ConfigureApplicationServices(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRequestService, RequestService>();
            services.AddScoped<IAcceptedRequestService, AcceptedRequestService>();
            services.AddScoped<IAuthService, AuthService>();
        }

        private void ConfigureDatabases(IServiceCollection services)
        {
            services.AddEntityFrameworkSqlServer();

            if (_environment.IsDevelopment())  //we can change this later once we get an actual db up and running
            {
                services.AddDbContextPool<MutualAidContext>((serviceProvider, optionsBuilder) =>
                {
                    optionsBuilder.UseSqlServer(Configuration.GetConnectionString("MutualAidDB"));
                    optionsBuilder.UseInternalServiceProvider(serviceProvider);
                });
            }
            else
            {
                services.AddDbContextPool<MutualAidContext>(opts =>
                    opts.UseSqlServer(Configuration.GetConnectionString("MutualAidDB")));
            }
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
          name: "areas",
          pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

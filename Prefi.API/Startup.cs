using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Prefi.Common.API.Filters;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;

namespace Prefi.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add HttpContext
            services.AddOptions();
            services.AddHttpContextAccessor();

            services
                .AddMvc(options => options.Filters.Add(typeof(BaseExceptionFilterAttribute)));
            //.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateTodoItemCommandValidator>());

            // Customise default API behavior
            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true; // disable the automatic 400 behavior
            });

            //services
            //    .ConfigurePersistence(Configuration)
            //    .ConfigureUploadMedia(Configuration)
            //    .ConfigureMediatrPipeline()
            //    .ConfigureIdentity(Configuration)
            //    .ConfigureEmailProvider(Configuration)
            //    .ConfigureWizIq(Configuration)
            //    .ConfigureStripe(Configuration)
            //    .ConfigureServices()
            //    .Configure<HubConfigurations>(options => Configuration.GetSection(nameof(HubConfigurations)).Bind(options));


            // TODO: Change to the domain
            services.AddCors(x => x.AddPolicy("AppPolicy",
                 builder => builder
                  //{
                  // builder.WithOrigins("http://localhost:64685", "https://localhost:44320")
                  //    .AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin(); 
                  //}
                  .AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader()
             ));
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors("AppPolicy");
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();

            app.UseRouting();

            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}/{id?}");
            });
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySystem.Api.Context;
using LibrarySystem.Api.Interfaces;
using LibrarySystem.Api.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace LibrarySystem.Api
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
            services.AddControllers();
            services.AddDbContext<LibraryDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("LibraryDbConnection")));
            services.AddScoped<IBooksRepository, BooksRepository>();
            services.AddSingleton<IAuthorsRepository, AuthorsRepository>();
            services.AddSingleton<IAnswersService, AnswersService>();
            //Adding the HttpClient
            services.AddHttpClient("StackOverFlowClient", client =>
            {
                //  Account Api Content Type 
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                client.BaseAddress = new Uri(Configuration.GetSection("AnswersServiceUrl").Value);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

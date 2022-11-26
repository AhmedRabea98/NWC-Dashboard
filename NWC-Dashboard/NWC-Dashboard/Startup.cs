using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using NWC_Dashboard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NWC_Dashboard
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
            services.AddHttpContextAccessor();
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder => builder.WithOrigins("http://nwcdashboards.dig-x.co.in", "http://localhost:3000").AllowAnyHeader()
                                                      .AllowAnyMethod().AllowCredentials().SetIsOriginAllowed(host => true));
                options.AddPolicy("MyPolicy", builder => builder.WithOrigins("http://nwcdashboards.dig-x.co.in", "http://localhost:3000").AllowAnyHeader()
                                                      .AllowAnyMethod().AllowCredentials().SetIsOriginAllowed(host => true));
            });
            services.AddControllers();
            services.AddDbContext<ApplicationDBContext>(options => options.UseOracle(Configuration.GetConnectionString("Connection")));
            services.AddDbContext<ApplicationDBContext2>(options => options.UseOracle(Configuration.GetConnectionString("Connection2")));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NWC_Dashboard", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "NWC_Dashboard v1"));
            }

            app.UseRouting();
            app.UseCors();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

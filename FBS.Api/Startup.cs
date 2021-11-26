using FBS.Domain.Dto.Response;
using FBS.Domain.Mappers;
using FBS.Domain.Models;
using FBS.InfraStructure.DataBase;
using FBS.InfraStructure.Extensions;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace FBS.Api
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
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FBS.Api", Version = "v1" });
            });

            var assembly = AppDomain.CurrentDomain.Load("FBS.Domain");
            services.AddMediatR(assembly);

            services.RepositoryExtension();

            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new PurchaseItemMapperProfile());
                cfg.AddProfile(new CategoryMapperProfile());
            });

            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);

            // currently to test using the in-memory database
            services.AddDbContext<DataBaseItemContext>(opt => opt.UseInMemoryDatabase("database"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FBS.Api v1"));
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

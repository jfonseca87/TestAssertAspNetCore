﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Class;
using Business.Interfaces;
using Domain;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Class;
using Repository.Interfaces;
using Swashbuckle.AspNetCore.Swagger;

namespace AssertAPI
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AssertContext>(options => 
                options.UseSqlServer(this.configuration["ConnectionStrings:AssertContext"])
            );

            //Repository container
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IFlightRepository, FlightRepository>();
            services.AddTransient<IUserFlightRegisterRepository, UserFlightRegisterRepository>();

            //Business container
            services.AddTransient<IUserBusiness, UserBusiness>();
            services.AddTransient<IFlightBusiness, FlightBusiness>();
            services.AddTransient<IUserFlightRegisterBusiness, UserFlightRegisterBusiness>();

            services.AddMvc();

            services.AddSwaggerGen(s => 
            {
                s.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Assert API",
                    Description = "API for users and flights register",
                    Contact = new Contact
                             {
                                Name = "Jorge Fonseca",
                                Email = "jorge.fonseca87@gmail.com"
                             }
                });
            });

            services.AddCors(o => o.AddPolicy("AssertAPIPolicy", build =>
                build.AllowAnyHeader()
                     .AllowAnyMethod()
                     .AllowAnyOrigin()
                     .AllowCredentials()
            ));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("/swagger/v1/swagger.json", "Assert API v1");
            });
            app.UseCors("AssertAPIPolicy");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirportRESRfulApi.BLL.Services;
using AirportRESRfulApi.DAL;
using AirportRESRfulApi.DAL.Models;
using AirportRESRfulApi.Shared.DTO;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace AirportRESRfulApi
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
            // DAL 
            services.AddScoped<IRepository<Ticket>, TicketsRepository>();
            services.AddScoped<IRepository<Flight>, FlightsRepository>();

            // DAL Context
            services.AddSingleton<IAirportContext, AirportContext>();

            //BLL
            services.AddScoped<ITicketService, TicketService>();
            services.AddScoped<IFlightsService, FlightsService>();

            //Maper
            services.AddScoped(_ => MapperConfiguration().CreateMapper());

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }

        public MapperConfiguration MapperConfiguration()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Ticket, TicketDto>();
                cfg.CreateMap<TicketDto, Ticket>();

                cfg.CreateMap<Flight, FlightDto>();
                cfg.CreateMap<FlightDto, Flight>();

                //cfg.CreateMap<Item, Services.DTOs.Item>()
                //    .ForMember(i => i.Labels, opt => opt.MapFrom(i => i.IteamLabels.Select(il => il.Label)));
                //cfg.CreateMap<Services.DTOs.Item, Item>()
                //    .ForMember(i => i.IteamLabels, opt => opt.Ignore())
                //    .ForMember(i => i.List, opt => opt.Ignore())
                //    .ForMember(i => i.ListId, opt => opt.Ignore());
            });

            return config;
        }
    }
}

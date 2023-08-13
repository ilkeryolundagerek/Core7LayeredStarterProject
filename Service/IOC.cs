using Core.Abstracts.IRepositories;
using Core.Abstracts.IServices;
using Core.Abstracts.IUnitOfWorks;
using Data.Contexts;
using Data.Repositories;
using Data.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class IOC
    {
        public static IServiceCollection AddAWServices(this IServiceCollection services, string connection_string)
        {
            services.AddDbContext<Aw14Context>(options => options.UseSqlServer(connection_string));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWorkProduction, UnitOfWorkProduction>();
            services.AddScoped<IProductionService, ProductionService>();
            return services;
        }
    }
}

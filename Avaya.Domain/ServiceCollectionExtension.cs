using Avaya.Core.Repositories;
using Avaya.Core.UoW;
using Avaya.Domain.Models;
using Avaya.Domain.Repositories;
using Avaya.Domain.UoW;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avaya.Domain
{
    public static class ServiceCollectionExtension
    {
        public static void ConfigureDomain(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SmartPhoneStoreContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("SmartPhoneStore")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRepository<Brands>, Repository<Brands>>();
            services.AddScoped<IRepository<CartDetails>, Repository<CartDetails>>();
            services.AddScoped<IRepository<Cart>, Repository<Cart>>();
            services.AddScoped<IRepository<ProductDetails>, Repository<ProductDetails>>();
            services.AddScoped<IRepository<Roles>, Repository<Roles>>();
            services.AddScoped<IRepository<UserRoles>, Repository<UserRoles>>();
            services.AddScoped<IRepository<SellHistory>, Repository<SellHistory>>();
            services.AddScoped<IRepository<Users>, Repository<Users>>();
            services.AddScoped<IRepository<Menu>, Repository<Menu>>();
        }
    }
}

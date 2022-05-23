using ETicaretAPI.Aplication.Abstractions;
using ETicaretAPI.Aplication.Repostories;
using ETicaretAPI.Persistence.Concretes;
using ETicaretAPI.Persistence.Contexts;
using ETicaretAPI.Persistence.Repostories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection service)
        {
            service.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));

            service.AddScoped<ICustomerReadRepostory, CustomerReadRepostory>();
            service.AddScoped<ICustomerWriteRepostory, CustomerWriteRepostory>();
            service.AddScoped<IOrderReadRepostory, OrderReadRepostory>();
            service.AddScoped<IOrderWriteRepostory, OrderWriteRepostory>();
            service.AddScoped<IProductReadRepostory, ProductReadRepostory>();
            service.AddScoped<IProductWriteRepostory, ProductWriteRepostory>();
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Services
{
    public static class ServicesRegistiration
    {
        public static void AddApplicationSevice(this IServiceCollection service,IConfiguration configuration)
        {
            service.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServicesRegistiration).Assembly));
        }
    }
}

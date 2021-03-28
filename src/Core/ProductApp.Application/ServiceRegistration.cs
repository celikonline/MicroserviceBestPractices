using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ProductApp.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection serviceCollection)
        {
            var assm = Assembly.GetExecutingAssembly();

            serviceCollection.AddAutoMapper(assm);
            serviceCollection.AddMediatR(assm);
        }
    }
}

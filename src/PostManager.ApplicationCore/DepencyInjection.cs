using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PostManager.ApplicationCore
{
    public static class DepencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            return services.AddMediatR(options =>
            {
                options.RegisterServicesFromAssembly(typeof(DepencyInjection).Assembly);
            });

            return services;
        }
    }
}

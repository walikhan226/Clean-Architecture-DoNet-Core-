using CleanArchitecture.Application.Features.Contacts;
using CleanArchitecture.Common.Config.App;
using CleanArchitecture.Infrastructure.Data;
using CleanArchitecture.Infrastructure.Repositories.Employee;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace CleanArchitecture.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {

        public  static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
           

            services.AddMediatR(typeof(InfrastructureServiceRegistration).Assembly);
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();

            return services;
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrustructure.IRepository;
using SchoolProject.Infrustructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Infrustructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection InfrustractureDependencies(this IServiceCollection services) 
        {
            services.AddScoped<IStudentRepository, StudentRepository>();
            return services;
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrustructure.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core
{
    public static class ModuleCoreDependencies
    {
        public static IServiceCollection CoreDependencies(this IServiceCollection services)
        {
            //Configuration of Mediator
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            //Configuration of Automapper
            services.AddAutoMapper(Assembly.GetExecutingAssembly());    
            return services;
        }
    }
}

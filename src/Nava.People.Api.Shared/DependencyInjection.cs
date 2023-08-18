using Nava.People.Api.Application.Services;
using Nava.People.Api.Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Nava.People.Api.Domain.Interfaces;
using Nava.People.Api.Persistence.Repositories;
using Nava.People.Api.Persistence;
using Microsoft.Extensions.Configuration;

namespace Nava.People.Api.Shared
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IPersonRepository, PersonRepository>(provider =>
            {
                return new PersonRepository(configuration);
            });

            return services;
        }

    }
}
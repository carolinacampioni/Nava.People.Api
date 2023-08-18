using Nava.People.Api.Application.Mappings;

namespace Nava.People.Api.Api.AutoMapConfig
{
    public static class AutoMapConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
        }
    }
}

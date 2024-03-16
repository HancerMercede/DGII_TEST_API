using DtosModels;
using Entities;
using Mapster;
using System.Reflection;

namespace DGII_TEST_API.Config
{
    public static class MappingConfiguration
    {
        public static void RegisterConfigurationMappers(this IServiceCollection services)
        {
            TypeAdapterConfig<Contributor, ContributorDto>.NewConfig();
            TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
        }
    }
}

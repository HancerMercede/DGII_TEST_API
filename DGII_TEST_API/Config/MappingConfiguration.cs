namespace DGII_TEST_API.Config;

public static class MappingConfiguration
{
    public static void RegisterConfigurationMappers(this IServiceCollection services)
    {
        TypeAdapterConfig<Contributor, ContributorDto>.NewConfig();
        TypeAdapterConfig<ComprobanteFiscal, ComprobanteFiscalDto>.NewConfig()
            .Map(dest => dest.Total, src =>  src.Monto + src.Itebis);
        TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());
    }
}

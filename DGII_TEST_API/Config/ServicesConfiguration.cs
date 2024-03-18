namespace DGII_TEST_API.Config;

public static class ServicesConfiguration
{
    public static void RegisteringSqlServer(this IServiceCollection services, string connection)
    {
       services.AddDbContext<ApplicationDbContext>(opt =>
        {
            opt.UseSqlServer(connection);
        });
    }

    public static void ConfiguredCors(this IServiceCollection services) =>
       services.AddCors(opt =>
       {
           opt.AddPolicy("AllowAll", builder =>
              builder.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
       });

}

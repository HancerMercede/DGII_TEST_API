using Contracts;
using Microsoft.EntityFrameworkCore;
using Persistence;
using Services;

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
}

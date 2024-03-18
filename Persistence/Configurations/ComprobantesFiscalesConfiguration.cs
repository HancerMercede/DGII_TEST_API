using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class ComprobantesFiscalesConfiguration : IEntityTypeConfiguration<ComprobanteFiscal>
{
    public void Configure(EntityTypeBuilder<ComprobanteFiscal> builder)
    {
        builder.HasData(
            new ComprobanteFiscal
            {
                Id = Guid.NewGuid(),
                RncCedula = "04000175463",
                NCF = "E310000000001",
                Monto = 2500.00,
                Itebis = 450.00
            },
            new ComprobanteFiscal
            {
                Id = Guid.NewGuid(),
                RncCedula = "045788655",
                NCF = "E310000000002",
                Monto = 2700.00,
                Itebis = 486.00
            },
             new ComprobanteFiscal
             {
                 Id = Guid.NewGuid(),
                 RncCedula = "98754321012",
                 NCF = "E310000000003",
                 Monto = 2700.00,
                 Itebis = 486.00
             },
              new ComprobanteFiscal
              {
                  Id = Guid.NewGuid(),
                  RncCedula = "045788655",
                  NCF = "E310000000004",
                  Monto = 2300.00,
                  Itebis = 414.00
              }
          );
    }
}

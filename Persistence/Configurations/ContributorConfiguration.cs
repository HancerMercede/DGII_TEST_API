using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

public class ContributorConfiguration : IEntityTypeConfiguration<Contributor>
{
    public void Configure(EntityTypeBuilder<Contributor> builder)
    {
        builder.HasData
            (
            new Contributor
            {
                ContributorId = Guid.NewGuid(),
                Name = "Cristino Almanzar".ToUpper(),
                Type = "Persona Fisica".ToUpper(),
                RncCedula = "04000175463",
                Status = Status.Activo
            },
            new Contributor
            {
                ContributorId = Guid.NewGuid(),
                Name = "Mario Martinez".ToUpper(),
                Type="Persona Fisica".ToUpper(),
                RncCedula="045788655",
                Status = Status.Activo

            }
        ) ;
    }
}

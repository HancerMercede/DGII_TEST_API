using Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Persistence;

public class ApplicationDbContext:DbContext 
{
    public ApplicationDbContext(DbContextOptions options):base(options)
    {
        
    }


    public DbSet<Contributor> Contributors { get; set; }
    public DbSet<ComprobanteFiscal> ComprobantesFiscales { get; set; }


    protected override void OnModelCreating(ModelBuilder builder) {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        // Contributor
        builder.Entity<Contributor>().ToTable("Contributors");
        builder.Entity<Contributor>().Property(c=>c.ContributorId).HasMaxLength(36).IsRequired();
        builder.Entity<Contributor>().Property(c=>c.Name).HasMaxLength(50).IsRequired();
        builder.Entity<Contributor>().Property(c=>c.RncCedula).HasMaxLength(11).IsRequired();
        builder.Entity<Contributor>().Property(c=>c.Type).HasMaxLength(50).IsRequired();
        builder.Entity<Contributor>().HasMany(c => c.ComprobantesFiscales).WithOne(cf=>cf.Contributor).HasPrincipalKey(cf=>cf.RncCedula);

        // ComprobantesFiscales
        builder.Entity<ComprobanteFiscal>().Property(cf => cf.Itebis).HasConversion<double>();
        builder.Entity<ComprobanteFiscal>().Property(cf => cf.NCF).HasMaxLength(20).IsRequired();
        builder.Entity<ComprobanteFiscal>().HasOne(c => c.Contributor).WithMany(x => x.ComprobantesFiscales).HasForeignKey(cf => cf.RncCedula);
    }
    
}

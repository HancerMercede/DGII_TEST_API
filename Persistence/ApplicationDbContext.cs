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
    public DbSet<ComprobantesFiscales> ComprobantesFiscales { get; set; }


    protected override void OnModelCreating(ModelBuilder builder) {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
    
}

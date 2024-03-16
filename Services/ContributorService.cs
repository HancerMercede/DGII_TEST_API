using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Services;

public class ContributorService : IContributorService
{
    private readonly ApplicationDbContext _context;
    public ContributorService(ApplicationDbContext context)
    {
        _context = context; 
    }
    public async Task<IEnumerable<Contributor>> GetAll()
    {
        return await _context.Contributors.ToListAsync();
    }

    public async Task<Contributor?> GetByDNI(string Cedula, bool tracking) =>
    
         !tracking ? 
          await _context.Contributors.AsNoTracking().FirstOrDefaultAsync(c => c.RncCedula == Cedula)!
            :  await _context.Contributors.FirstOrDefaultAsync(c => c.RncCedula == Cedula)!;
    
}

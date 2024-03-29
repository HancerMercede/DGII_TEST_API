﻿using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Services;

public class ComprobantesFiscalesService : ICFiscalesService
{
    private readonly ApplicationDbContext _context;

    public ComprobantesFiscalesService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<ComprobanteFiscal>> GetAll(bool tracking)
    {
        return !tracking ? await _context.ComprobantesFiscales
            .AsNoTracking()
            .Include(c=>c.Contributor)
            .ToListAsync() :
            await _context.ComprobantesFiscales.Include(c=>c.Contributor)
            .ToListAsync();
    }

    public async Task<ComprobanteFiscal?> GetById(string Id, bool tracking)
    {
        return !tracking ? await _context.ComprobantesFiscales.AsNoTracking().FirstOrDefaultAsync(cf => cf.Id == Guid.Parse(Id)!) :
            await _context.ComprobantesFiscales.FirstOrDefaultAsync(cf => cf.Id == Guid.Parse(Id)!);
    }
}

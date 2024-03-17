using Entities;

namespace Contracts;

public interface ICFiscalesService
{
    Task<IEnumerable<ComprobanteFiscal>> GetAll(bool tracking);
    Task<ComprobanteFiscal> GetById(string Id);
}

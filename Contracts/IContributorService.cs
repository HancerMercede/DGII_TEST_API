using Entities;

namespace Contracts;

public interface IContributorService
{
    Task<IEnumerable<Contributor>> GetAll();
    Task<Contributor> GetByDNI(string Cedula, bool tracking);
    Task Save();
}
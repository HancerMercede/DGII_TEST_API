
namespace Entities;

public class ComprobanteFiscal
{
    public Guid Id { get; set; }
    public virtual Contributor? Contributor { get; set; }
    public string? RncCedula { get; set; }
    public string? NCF { get; set; }
    public double Monto { get; set; }
    public double Itebis { get; set; }
}


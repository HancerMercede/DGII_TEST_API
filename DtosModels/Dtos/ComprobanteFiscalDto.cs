namespace DtosModels.Dtos;

public class ComprobanteFiscalDto
{
    public Guid Id { get; set; }
    public string? RncCedula { get; set; }
    public string? NCF { get; set; }
    public double Monto { get; set; }
    public double Itebis { get; set; }
    public double Total { get; set; }
}

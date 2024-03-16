namespace DtosModels;


public enum Status { Activo = 1, inactivo = 0 }
public class ContributorDto
{
    public Guid ContributorId { get; set; }
    public string? RncCedula { get; set; }
    public string? Name { get; set; }

    public string? Type { get; set; }
    public Status Status { get; set; }
}
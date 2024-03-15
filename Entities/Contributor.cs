namespace Entities;


public enum Status { Activo = 1, inactivo = 0 }
public class Contributor
{
    public Guid ContributorId { get; set; }
    public string? RncCedula { get; set; }
    public string? Name { get; set; }
    public Status Status { get; set; }
}
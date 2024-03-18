

namespace DtosModels.Dtos;

public enum StatusCreateDtos { Activo = 1, inactivo = 0 }
public class ContributorCreateDto
{
    public string? RncCedula { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public StatusCreateDtos Status { get; set; }
}

using Contracts;
using DtosModels;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace DGII_TEST_API.Controllers;

[ApiController]
[Route("[controller]")]
public class ContributorController : ControllerBase
{
    private readonly ILogger<ContributorController> _logger;
    private readonly IContributorService _service;

    public ContributorController(ILogger<ContributorController> logger, IContributorService service)
    {
        _logger = logger;
        _service = service;
    }

    [HttpGet(Name = "GetAll")]
    public async Task<IEnumerable<ContributorDto>> GetAll() {
        try
        {
            _logger.LogInformation("Getting all the contributors.");
            var contributors = await _service.GetAll();
            var dtos = contributors.Adapt<IEnumerable<ContributorDto>>();
            return dtos;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error:{ex.Message}");
            throw new Exception(ex.Message);
        }

    }

    [HttpGet("{Cedula}", Name = "GetByCedula")]
    public async Task<ContributorDto> GetById(string Cedula) {

        var dbEntity = await _service.GetByDNI(Cedula, tracking: false);

        var dto = dbEntity.Adapt<ContributorDto>();

        return dto;
    
    }
}

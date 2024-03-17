using Contracts;
using DtosModels;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace DGII_TEST_API.Controllers;

[ApiController]
[Route("[controller]")]
[Produces("application/json")]
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

        _logger.LogInformation("Getting the entity in the db.");
        var dbEntity = await _service.GetByDNI(Cedula, tracking: false);

        _logger.LogInformation("making a mapping to the dto.");
        var dto = dbEntity.Adapt<ContributorDto>();

        _logger.LogInformation("returning the dto to the client.");
        return dto;
    
  }
}

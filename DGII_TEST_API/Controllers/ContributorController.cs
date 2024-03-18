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

            _logger.LogInformation("Mapping to the dtos.");
            var dtos = contributors.Adapt<IEnumerable<ContributorDto>>();


            _logger.LogInformation("returning the dtos to the client.");
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

    [HttpPost]
    public async Task<ActionResult<ContributorDto>> Create([FromBody] ContributorCreateDto model)
    {
        if (model is null) return BadRequest("The model can be null");

        var UpperName = model?.Name?.ToUpper();
        var UpperType = model?.Type?.ToUpper();
        model.Name = UpperName;
        model.Type = UpperType;

        var dbEntity = model.Adapt<Contributor>();

        await _service.Create(dbEntity);
        await _service.Save();

        var dto = dbEntity.Adapt(model);
        return CreatedAtRoute("GetByCedula", new { Cedula = dto?.RncCedula }, dto);
    }
        

}

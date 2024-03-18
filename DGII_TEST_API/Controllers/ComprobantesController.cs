namespace DGII_TEST_API.Controllers;

[ApiController]
[Route("[controller]")]
[Produces("application/json")]
public class ComprobantesController:ControllerBase
{
    private readonly ILogger<ComprobantesController> _logger;
    private readonly ICFiscalesService _service;

    public ComprobantesController(ILogger<ComprobantesController> logger, ICFiscalesService service)
    {
        _logger = logger;
        _service = service;

    }

    [HttpGet(Name = "GetAllComprobantes")]
    public async Task<IEnumerable<ComprobanteFiscalDto>> Get()
    {
        try
        {
            _logger.LogInformation("Getting all the comprobantes.");
            var dbEntities = await _service.GetAll(tracking: false);

            _logger.LogInformation("Mapping the info to the dtos models.");
            var dtos = dbEntities.Adapt<IEnumerable<ComprobanteFiscalDto>>();

            _logger.LogInformation("returning the data.");
            return dtos;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error: {ex.Message}");
            throw new Exception(ex.Message);
        }

    }

    [HttpGet("{Id}", Name = "GetComprobanteByDNI")]
    public async Task<ComprobanteFiscalDto> GetByDNI(string Id)
    {
        try
        {
            _logger.LogInformation("Getting the comprobante by its Id.");
            var dbEntity = await _service.GetById(Id, tracking:false);

            _logger.LogInformation("Mapping the info to the dto model.");
            var dto = dbEntity.Adapt<ComprobanteFiscalDto>();

            _logger.LogInformation("returning the data.");
            return dto;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error: {ex.Message}");
            throw new Exception(ex.Message);
        }

    }

}

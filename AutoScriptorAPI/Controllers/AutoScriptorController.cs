using AutoScriptor.Infrastructure.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AutoScriptorAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AutoScriptorController : ControllerBase
{
    private readonly ILogger<AutoScriptorController> _logger;
    private readonly IRequestHandler _requestHandler;

    public AutoScriptorController(ILogger<AutoScriptorController> logger, IRequestHandler requestHandler)
    {
        _logger = logger;
        _requestHandler = requestHandler;
    }

    /// <summary>
    /// Heartbeat for checking if API is alive.
    /// </summary>
    /// <remarks>
    /// Sample request
    /// 
    ///     GET api/Heartbeat
    /// </remarks>
    /// <response code="200">A 200 returns response succesfully.</response>
    /// <response code="401">A 401 if the specified token is not authorized.</response>
    /// <response code="500">A 500 something wrong has happened.</response>
    /// <returns></returns>
    [HttpGet(Name = "Alive")]
    public async Task<IActionResult> Alive()
    {        
        return Ok("API is alive");
    }

    /// <summary>
    /// Returns prescription given prescriptionNumber
    /// </summary>
    /// <remarks>
    /// Sample request
    /// 
    ///     POST api/PrescriptionRetrieve
    /// </remarks>
    /// <response code="200">A 200 returns response succesfully.</response>
    /// <response code="401">A 401 if the specified token is not authorized.</response>
    /// <response code="500">A 500 something wrong has happened.</response>
    /// <returns></returns>
    [HttpPost(Name = "PrescriptionRetrieve")]
    public async Task<IActionResult> PrescriptionRetrieve([FromQuery] string prescriptionNumber)
    {
        return Ok(await _requestHandler.HandleRequestPrescriptionRetrieve(prescriptionNumber).ConfigureAwait(false));
    }
}

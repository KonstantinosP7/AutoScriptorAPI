using AutoScriptor.Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;

namespace AutoScriptorAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class AutoScriptorController : ControllerBase
{
    private readonly ILogger<AutoScriptorController> _logger;

    public AutoScriptorController(ILogger<AutoScriptorController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "PrescriptionRetrieve")]
    public async Task<IActionResult> PrescriptionRetrieve()
    {
        var services = new EoppyEservices();
        var res = await services.Prescription_Retrieve().ConfigureAwait(false);
        return Ok(res);
    }
}

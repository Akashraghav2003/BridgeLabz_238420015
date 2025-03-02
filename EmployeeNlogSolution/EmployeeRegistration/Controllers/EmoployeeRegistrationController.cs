using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Logging;

namespace EmployeeRegistration.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class EmoployeeRegistrationController : Controller
    {
        private readonly ILogger<EmoployeeRegistrationController> _logger;

        public EmoployeeRegistrationController(ILogger<EmoployeeRegistrationController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        public IActionResult Get ()
        {
            _logger.LogInformation("Fetching Employee data");
            try
            {
                int count = 5 + 10;
                _logger.LogDebug($"Employee Count: {count}");
                return Ok(new { Message = "Employee data retrive successfull" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occured");
                return NotFound();
            }
        }



    }
}

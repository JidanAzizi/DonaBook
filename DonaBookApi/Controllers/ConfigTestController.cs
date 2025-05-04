using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using DonaBookApi.Model;

namespace DonaBookApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigTestController : ControllerBase
    {
        private readonly AppSettings _settings;

        public ConfigTestController(IOptions<AppSettings> settings)
        {
            _settings = settings.Value;
        }

        [HttpGet]
        public IActionResult GetConfig()
        {
            return Ok(new
            {
                AppName = _settings.AppName,
                Version = _settings.Version,
                LoggingEnabled = _settings.EnableLogging
            });
        }
    }
}

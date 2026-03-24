using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SerilogDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SerilogDemoController : ControllerBase
    {

        private readonly ILogger<SerilogDemoController> logger;

        public SerilogDemoController(ILogger<SerilogDemoController> logger)
        {
            this.logger= logger;
        }

        [HttpGet]
        public IActionResult display()
        {
            logger.LogInformation("THis is an informational message using Serilog");
            return Ok("Information Logged into a file log.txt, plz check......");
        }

        [HttpGet("error")]
        public IActionResult getError()
        {
            try
            {
                int a = 100, b = 0;
                int res = a / b;
                return Ok(res);

            }
            catch
            {
                logger.LogError("An Error occured in ur api");
                return StatusCode(500, "An error occured plz check ur log files ....");

            }
        }
    }
}

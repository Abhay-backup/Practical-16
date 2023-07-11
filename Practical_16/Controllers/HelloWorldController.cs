using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Practical_16.Controllers
{



    //[ApiController]
    //[Route("[controller]")]
    //public class HelloWorldController : ControllerBase
    //{
    //    private readonly ILogger<HelloWorldController> _logger;

    //    public HelloWorldController(ILogger<HelloWorldController> logger)
    //    {
    //        _logger = logger;
    //    }

    //    [HttpGet]
    //    public ActionResult<string> Get()
    //    {
    //        _logger.LogInformation("Hello World API was called.");
    //        return "Hello World!";
    //    }
    //}
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Hello World API was called.");

            return Ok("Hello World");
        }
    }

}
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpGet("ShowName")]
        public string FnShowName()
        {
            return "Hello Team";
        }

        [HttpGet("FnHelloWorld")]
        public string FnHelloWorld()
        {
            return "Hello World";
        }

    }
}

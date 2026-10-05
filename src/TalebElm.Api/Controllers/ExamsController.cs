using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TalebElm.Api.Controllers
{
 
    [ApiController]
    [Route("api/[controller]")]
    public class ExamsController : ControllerBase 
    {
        [HttpGet("{id}")]
        public IActionResult Get(Guid id) => NotImplementedException();
        [HttpPost]
        public IActionResult Post() => NotImplementedException();
        [HttpPost("{id}/submit")]
        public IActionResult Submit(Guid id) => NotImplementedException();
    }
}

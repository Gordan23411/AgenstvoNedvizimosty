using AgenstvoNedvizimosty.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgenstvoNedvizimosty.Api.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class TargetController : ControllerBase
        {
            [HttpGet]
            public IActionResult GetAllTargetController()
            {
                var context = new AgenstvoNedvizimostyContext();
                var targetlist = context.Targets.ToList();

                return Ok(targetlist);
            }
        }
    }
}

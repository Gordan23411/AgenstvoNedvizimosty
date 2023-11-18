using AgenstvoNedvizimosty.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgenstvoNedvizimosty.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TuristController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllTuristController()
        {
            var context = new AgenstvoNedvizimostyContext();
            var turistlist = context.Turists.ToList();

            return Ok(turistlist);
        }
    }
}

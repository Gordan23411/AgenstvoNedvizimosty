using AgenstvoNedvizimosty.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgenstvoNedvizimosty.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TurOperController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllTurOperController()
        {
            var context = new AgenstvoNedvizimostyContext();
            var turOper = context.TurOper.ToList();

            return Ok(turOper);
        }
    }
}

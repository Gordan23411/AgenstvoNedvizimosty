
using Microsoft.AspNetCore.Mvc;
using TimeTable207.Context;
using TimeTable207.Context.Contracts;

namespace AgenstvoNedvizimosty.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class TuristController : ControllerBase
    {
        [HttpGet] // localhost:1111224/group
        public IActionResult Turist()
        {
            var context = new TimeTableContext() as ITimeTableContext;
            var turists = context.Turists.ToList();
            return Ok(turists);
        }
    }
}

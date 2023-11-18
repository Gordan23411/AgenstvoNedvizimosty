using AgenstvoNedvizimosty.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgenstvoNedvizimosty.Api.Controllers
{
    namespace AgenstvoNedvizimosty.Api.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class PutTargetItemController : ControllerBase
        {
            [HttpGet]
            public IActionResult GetAllPutTargerItemController()
            {
                var context = new AgenstvoNedvizimostyContext();
                var puttargetlist = context.PutTargetItems.ToList();

                return Ok(puttargetlist);
            }
        }
    }

}

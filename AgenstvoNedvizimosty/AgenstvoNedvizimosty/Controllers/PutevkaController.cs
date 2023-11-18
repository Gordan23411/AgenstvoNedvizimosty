using AgenstvoNedvizimosty.Context;
using Microsoft.AspNetCore.Mvc;

namespace AgenstvoNedvizimosty.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PutevkaController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllPutevka() 
        {
            var context = new AgenstvoNedvizimostyContext();
            var turistlist = context.Turists.ToList();

            return Ok(turistlist);
        }
    }
}

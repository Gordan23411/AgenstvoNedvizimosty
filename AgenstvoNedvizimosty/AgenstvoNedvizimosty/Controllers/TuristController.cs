using AgenstvoNedvizimosty.Context;
using AgenstvoNedvizimosty.Context.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AgenstvoNedvizimosty.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TuristController : ControllerBase
    {
        private readonly IAgenstvoNedvizimostyContext context;

        public TuristController(IAgenstvoNedvizimostyContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public IActionResult GetAllTuristController()
        {
    
            var turistlist = context.Turists.ToList();

            return Ok(turistlist);
        }
        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var turistlist = context.Turists.FirstOrDefault(x => x.Id == id);
            return Ok(turistlist);
        }
    }
}

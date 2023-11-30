using FinalProject_BJSS5.Data;
using FinalProject_BJSS5.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_BJSS5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IntroController : Controller
    {
        IFinalService ctx;
        public IntroController(IFinalService ctx)
        {
            this.ctx = ctx;
        }

        [HttpGet]
        [Route("getintros")]
        public IActionResult GetIntros()
        {
            return Ok(ctx.GetAllIntros());
        }

        [HttpGet]
        [Route("id")]
        public IActionResult GetIntros(int id)
        {
            var intro = ctx.GetIntroById(id);
            if (intro == null || id == 0)
            {
                return NotFound(id);
            }
            return Ok(intro);
        }

        [HttpPost]
        [Route("createintro")]
        public IActionResult PostIntro(Intro i)
        {
            var result = ctx.AddIntro(i);
            if (result == null)
            {
                return StatusCode(500, "An intro with this ID already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request.");
            }
            return Ok();
        }

        [HttpPut]
        [Route("updateintro")]
        public IActionResult PutIntro(Intro i)
        {
            var result = ctx.UpdateIntro(i);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete("introid")]
        public IActionResult DeleteIntro(int id)
        {
            var result = ctx.RemoveIntroById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            if (result == null)
            {
                return StatusCode(500, "Intro not found.");
            }
            return Ok();
        }

    }
}

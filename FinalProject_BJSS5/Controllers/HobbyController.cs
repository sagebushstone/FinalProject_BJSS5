using FinalProject_BJSS5.Data;
using FinalProject_BJSS5.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_BJSS5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HobbyController : Controller
    {
        IFinalService ctx;
        public HobbyController(IFinalService ctx)
        {
            this.ctx = ctx;
        }
        
        [HttpGet]
        [Route("gethobbies")]
        public IActionResult GetHobbies()
        {
            return Ok(ctx.GetAllHobbies());
        }

        [HttpGet("id")]
        public IActionResult GetHobbies(int id)
        {
            var hobby = ctx.GetHobbyById(id);
            if (hobby == null || id == 0)
            {
                return Ok(ctx.GetAllHobbies().Take(5));
            }
            return Ok(hobby);
        }

        [HttpPost]
        [Route("createhobby")]
        public IActionResult PostHobby(Hobbies p)
        {
            var result = ctx.AddHobby(p);
            if (result == null)
            {
                return StatusCode(500, "A book with this ID already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request.");
            }
            return Ok();
        }

        [HttpPut]
        [Route("updatehobby")]
        public IActionResult PutHobby(Hobbies b)
        {
            var result = ctx.UpdateHobby(b);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete("hobbyid")]
        public IActionResult DeleteHobby(int id)
        {
            var result = ctx.RemoveHobbyById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            if (result == null)
            {
                return StatusCode(500, "Product not found.");
            }
            return Ok();
        }

    }
}

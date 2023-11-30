using FinalProject_BJSS5.Data;
using FinalProject_BJSS5.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_BJSS5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FavoriteController : Controller
    {
        IFinalService ctx;
        public FavoriteController(IFinalService ctx)
        {
            this.ctx = ctx;
        }
        [HttpGet]
        [Route("getfavorites")]
        public IActionResult GetFavorites()
        {
            return Ok(ctx.GetAllFavorites());
        }

        [HttpGet]
        [Route("getfavoritebyid")]
        public IActionResult GetFavoriteById(int id)
        {
            var favorite = ctx.GetFavoriteById(id);
            if (favorite == null)
            {
                return StatusCode(404, "No favorite item found");
            }

            return Ok(favorite);
        }

        [HttpPost]
        [Route("createfavorite")]
        public IActionResult PostFavorite(Favorite f)
        {
            var result = ctx.AddFavorite(f);
            if (result == null)
            {
                return StatusCode(500, "A favorite with this ID already exists");
            }
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request.");
            }
            return Ok(f);
        }

        [HttpPut]
        [Route("updatefavorite")]
        public IActionResult PutFavorite(Favorite f)
        {
            var result = ctx.UpdateFavorite(f);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            if (result == null)
            {
               return StatusCode(404, "No favorite item found");
            }
            return Ok(f);
        }

        [HttpDelete("removefavorite")]
        public IActionResult DeleteFavorite(int id)
        {            
            var result = ctx.RemoveFavoriteById(id);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            if (result == null)
            {
               return StatusCode(404, "No favorite item found");
            }
            return Ok();
        }
    }
}

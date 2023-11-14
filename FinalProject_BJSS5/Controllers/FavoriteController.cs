using FinalProject_BJSS5.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_BJSS5.Controllers
{
    public class FavoriteController : Controller
    {
        FinalContext ctx;
        public FavoriteController(FinalContext ctx)
        {
            this.ctx = ctx;
        }
        public IActionResult Index()
        {
            return Ok(ctx.Favorites.ToList());
            //return View();
        }
    }
}

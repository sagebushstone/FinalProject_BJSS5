using FinalProject_BJSS5.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_BJSS5.Controllers
{
    public class HobbyController : Controller
    {
        FinalContext ctx;
        public HobbyController(FinalContext ctx)
        {
            this.ctx = ctx;
        }
        public IActionResult Index()
        {
            return Ok(ctx.Hobbies.ToList());
            //return View();
        }
    }
}


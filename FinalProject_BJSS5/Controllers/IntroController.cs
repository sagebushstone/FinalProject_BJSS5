using FinalProject_BJSS5.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_BJSS5.Controllers
{
    public class IntroController : Controller
    {
        FinalContext ctx;
        public IntroController(FinalContext ctx)
        {
            this.ctx = ctx;
        }
        public IActionResult Index()
        {
            return Ok(ctx.Intros.ToList());
            //return View();
        }
    }
}

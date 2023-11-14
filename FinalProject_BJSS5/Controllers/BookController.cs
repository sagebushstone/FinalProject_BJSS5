using FinalProject_BJSS5.Data;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_BJSS5.Controllers
{
    public class BookController : Controller
    {
        FinalContext ctx;
        public BookController(FinalContext ctx)
        {
            this.ctx = ctx;
        }
        public IActionResult Index()
        {
            return Ok(ctx.Books.ToList());
            //return View();
        }
    }
}

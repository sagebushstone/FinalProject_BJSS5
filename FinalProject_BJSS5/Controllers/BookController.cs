using FinalProject_BJSS5.Data;
using Microsoft.AspNetCore.Mvc;
using FinalProject_BJSS5.Models;

namespace FinalProject_BJSS5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : Controller
    {
        IFinalService ctx;
        public BookController(IFinalService ctx)
        {
            this.ctx = ctx;
        }

        [HttpGet]
        [Route("getbooks")]
        public IActionResult GetBooks()
        {
            return Ok(ctx.GetAllBooks());
        }

        [HttpGet("id")]
        public IActionResult GetBooks(int id) 
        {
            if (ctx.GetBookById(id).Count == 0)
            {
                return Ok(ctx.GetBookById(0));
            }
            return Ok(ctx.GetBookById(id));
        }

        [HttpPost]
        [Route("createbook")]
        public IActionResult PostBook(Book p)
        {
            var result = ctx.AddBook(p);
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
        [Route("updatebook")]
        public IActionResult PutBook(Book b)
        {
            var result = ctx.UpdateBook(b);
            if (result == 0)
            {
                return StatusCode(500, "An error occured while processing your request");
            }
            return Ok();
        }

        [HttpDelete("bookid")]
        public IActionResult DeleteBook(int id)
        {
            /*var book = ctx.GetBookById(id);
            if (book == null)
            {
                return NotFound(id);
            }*/
            var result = ctx.RemoveBookById(id);
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

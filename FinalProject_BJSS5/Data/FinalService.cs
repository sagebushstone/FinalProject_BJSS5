using FinalProject_BJSS5.Models;

namespace FinalProject_BJSS5.Data
{
    public class FinalService : IFinalService
    {
        FinalContext ctx;
        public FinalService(FinalContext context)
        {
            ctx = context;
        }

        // BOOK TABLE
        public List<Book> GetAllBooks()
        {
            return ctx.Books.ToList();
        }
        public Book GetBookById(int id)
        {
            return ctx.Books.FirstOrDefault(x => x.Id == id);
        }
        public int? AddBook(Book b)
        {
            var book = this.GetBookById(b.Id);
            if (book != null)
            {
                return null;
            }
            ctx.Books.Add(b);
            return ctx.SaveChanges();
        }
        public int? UpdateBook(Book b)
        {
            ctx.Books.Update(b);
            return ctx.SaveChanges();
        }
        public int? RemoveBookById(int id)
        {
            var book = this.GetBookById(id);
            if (book == null)
            {
                return null;
            }
            ctx.Books.Remove(book);
            return ctx.SaveChanges();
        }

        // FAVORITE TABLE

        // HOBBY TABLE

        // INTRO TABLE
    }
}

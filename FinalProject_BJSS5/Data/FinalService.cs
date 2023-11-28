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
        public List<Book> GetBookById(int? id)
        {
            if(id == 0 || id == null)
            {
                return ctx.Books.Take(5).Cast<Book>().ToList();
            }
            return ctx.Books.Where(item => item.Id == id).Cast<Book>().ToList();
        }
        public int? AddBook(Book b)
        {
            var book = this.GetBookById(b.Id);
            /*if (book != null)
            {
                return null;
            }*/
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
            var book = GetBookById(id);
            if (book == null)
            {
                return null;
            }
            if(book.FirstOrDefault() == null)
            {
                return null;
            }
            ctx.Books.Remove(book.FirstOrDefault());
            return ctx.SaveChanges();
        }



        // FAVORITE TABLE

        // HOBBY TABLE

        public List<Hobbies> GetAllHobbies()
        {
            return ctx.Hobbies.ToList();
        }

        public List<Hobbies> GetHobbyById(int? id)
        {
           // if (id == 0 || id == null)
           // {
           //     return ctx.Hobbies.Take(5).Cast<Hobbies>().ToList();
           // }
            return ctx.Hobbies.Where(item => item.Id == id).Cast<Hobbies>().ToList();
        }

        public int? AddHobby(Hobbies b)
        {
            var hobby = this.GetHobbyById(b.Id);
            ctx.Hobbies.Add(b);
            return ctx.SaveChanges();
        }

        public int? UpdateHobby(Hobbies b)
        {
            ctx.Hobbies.Update(b);
            return ctx.SaveChanges();
        }

        public int? RemoveHobbyById(int id)
        {
            var hobby = GetHobbyById(id);
            if (hobby == null || hobby.FirstOrDefault() == null)
            {
                return null;
            }
            ctx.Hobbies.Remove(hobby.FirstOrDefault());
            return ctx.SaveChanges();
        }

        // INTRO TABLE
    }
}

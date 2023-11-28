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
        public List<Favorite> GetAllFavorites()
        {
            return ctx.Favorites.ToList();
        }

        public Favorite GetFavoriteById(int id)
        {
            return ctx.Favorites.FirstOrDefault(x => x.Id == id);
        }

        public int? AddFavorite(Favorite f)
        {
            var favorite = this.GetFavoriteById(f.Id);
            if (favorite != null)
            {
                return null;
            }
            ctx.Favorites.Add(f);
            return ctx.SaveChanges();
        }

        public int? UpdateFavorite(Favorite f)
        {
            ctx.Favorites.Update(f);
            return ctx.SaveChanges();
        }

        public int? RemoveFavoriteById(int id)
        {
            var favorite = this.GetFavoriteById(id);
            if (favorite == null)
            {
                return null;
            }
            ctx.Favorites.Remove(favorite);
            return ctx.SaveChanges();
        }

        

        // HOBBY TABLE

        // INTRO TABLE
    }
}

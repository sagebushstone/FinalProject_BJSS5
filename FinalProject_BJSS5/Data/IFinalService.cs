using FinalProject_BJSS5.Models;

namespace FinalProject_BJSS5.Data
{
    public interface IFinalService
    {
        // BOOK TABLE
        List<Book> GetAllBooks();
        List<Book> GetBookById(int? id);
        int? AddBook(Book b);
        int? UpdateBook(Book b);
        int? RemoveBookById(int id);

        // FAVORITE TABLE

        // HOBBY TABLE
        List<Hobbies> GetAllHobbies();
        List<Hobbies> GetHobbyById(int? id);
        int? AddHobby(Hobbies b);
        int? UpdateHobby(Hobbies b);
        int? RemoveHobbyById(int id);

        // INTRO TABLE
    }
}

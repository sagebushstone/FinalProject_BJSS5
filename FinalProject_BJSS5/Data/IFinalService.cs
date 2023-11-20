﻿using FinalProject_BJSS5.Models;

namespace FinalProject_BJSS5.Data
{
    public interface IFinalService
    {
        // BOOK TABLE
        List<Book> GetAllBooks();
        Book GetBookById(int id);
        int? AddBook(Book b);
        int? UpdateBook(Book b);
        int? RemoveBookById(int id);

        // FAVORITE TABLE

        // HOBBY TABLE

        // INTRO TABLE
    }
}

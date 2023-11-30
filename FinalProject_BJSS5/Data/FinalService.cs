﻿using FinalProject_BJSS5.Models;
using Microsoft.EntityFrameworkCore;

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
        public List<Favorite> GetAllFavorites()
        {
            return ctx.Favorites.ToList();
        }

        public Favorite? GetFavoriteById(int? id)
        {
            if(id == 0 || id == null)
            {
                return null;
            }
            return ctx.Favorites.FirstOrDefault(x => x.Id == id);
        }


        public int? AddFavorite(Favorite f)
        {
            var favorite = GetFavoriteById(f.Id);
            if (favorite != null)
            {
                return null;
            }
            ctx.Favorites.Add(f);
            return ctx.SaveChanges();
        }

        public int? UpdateFavorite(Favorite f)
        {
            var favorite = GetFavoriteById(f.Id);
            if (favorite == null)
            {
                return null;
            }
            favorite.Food = f.Food;
            favorite.Name = f.Name;
            favorite.Movie = f.Movie;
            favorite.Drink = f.Drink;
            favorite.Color = f.Color;

            ctx.Favorites.Update(favorite);
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

        public List<Hobbies> GetAllHobbies()
        {
            return ctx.Hobbies.ToList();
        }

        public List<Hobbies> GetHobbyById(int? id)
        {
            return ctx.Hobbies.Where(item => item.Id == id).Cast<Hobbies>().ToList();
        }

        public int? AddHobby(Hobbies h)
        {
            var hobby = this.GetHobbyById(h.Id);
            ctx.Hobbies.Add(h);
            return ctx.SaveChanges();
        }

        public int? UpdateHobby(Hobbies h)
        {
            ctx.Hobbies.Update(h);
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
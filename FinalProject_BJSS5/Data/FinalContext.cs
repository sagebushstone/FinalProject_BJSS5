using Microsoft.EntityFrameworkCore;
using FinalProject_BJSS5.Models;

namespace FinalProject_BJSS5.Data
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options) :
            base(options) { }
        public DbSet<Book> Books { get; set;}
        public DbSet<Favorite> Favorites{ get; set; }

        public DbSet<Hobbies> Hobbies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
               new Book { Id = 1, Name = "Bidhatri", Title = "Little Women", Author = "Louisa May Alcott", Publisher = "Simon & Schuster", PublishYear = 1868},
                new Book { Id = 2, Name = "Jasmine", Title = "Days at the Morisaki Bookshop", Author = "Satoshi Yagisawa", Publisher = "Harper Perennial", PublishYear = 2023 },
                new Book { Id = 3, Name = "Sage", Title = "Les Miserables", Author = "Victor Hugo", Publisher = "A. Lacroix, Verboeckhoven & Cie.", PublishYear = 1862 },
                new Book { Id = 4, Name = "Sydney", Title = "Ballet Shoes", Author = "Noel Streatfeild", Publisher = "J. M. Dent & Sons", PublishYear = 1936 }
               );

            modelBuilder.Entity<Favorite>().HasData(
              new Favorite { Id = 1, Name = "Bidhatri", Food = "Cheesecake", Color = "Purple", Movie = "Pride and Prejudice", Drink = "Bubble Tea" },
               new Favorite { Id = 2, Name = "Jasmine", Food = "Sushi", Color = "Green", Movie = "The Meg 2", Drink = "Matcha" },
               new Favorite { Id = 3, Name = "Sage", Food = "Mashed Potatoes", Color = "Blue", Movie = "First Blood", Drink= "Gold Peak Tea" },
               new Favorite { Id = 4, Name = "Sydney", Food = "Cucumber", Color = "grey", Movie = "Z-O-M-B-I-E-S", Drink = "Water" }
              );

            modelBuilder.Entity<Hobbies>().HasData(
              new Hobbies { Id = 1, Name = "Bidhatri", Hobby1 = "Travelling", Hobby2 = "Painting", Hobby3 = "Basketball", Hobby4 = "Snorkeling" },
               new Hobbies { Id = 2, Name = "Jasmine", Hobby1 = "Scuba Diving", Hobby2 = "Photography", Hobby3 = "Cooking", Hobby4 = "Martial Arts" },
               new Hobbies { Id = 3, Name = "Sage", Hobby1 = "Reading", Hobby2 = "Drawing", Hobby3 = "Writing", Hobby4 = "Cooking" },
               new Hobbies { Id = 4, Name = "Sydney", Hobby1 = "Gaming", Hobby2 = "Reading", Hobby3 = "Crafting", Hobby4 = "Writing" }
              );
        }
    }
}

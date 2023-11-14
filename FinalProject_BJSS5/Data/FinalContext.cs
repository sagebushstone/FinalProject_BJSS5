using Microsoft.EntityFrameworkCore;
using FinalProject_BJSS5.Models;

namespace FinalProject_BJSS5.Data
{
    public class FinalContext : DbContext
    {
        public FinalContext(DbContextOptions<FinalContext> options) :
            base(options) { }
        public DbSet<Book> Books { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
               new Book { Id = 1, Name = "Bidhatri", Title = "Little Women", Author = "Louisa May Alcott", Publisher = "Simon & Schuster", PublishYear = 1868},
                new Book { Id = 2, Name = "Jasmine", Title = "Days at the Morisaki Bookshop", Author = "Satoshi Yagisawa", Publisher = "Harper Perennial", PublishYear = 2023 },
                new Book { Id = 3, Name = "Sage", Title = "Les Miserables", Author = "Victor Hugo", Publisher = "A. Lacroix, Verboeckhoven & Cie.", PublishYear = 1862 },
                new Book { Id = 4, Name = "Sydney", Title = "Ballet Shoes", Author = "Noel Streatfeild", Publisher = "J. M. Dent & Sons", PublishYear = 1936 }
               );
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLibrary.Models;

namespace WebLibrary.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<BookPlacement> BookPlacement { get; set; }

        // This method is used to seed the database with data (Note needs to be populated properly)
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookPlacement>().HasData(new BookPlacement { BookGenre = Genre.Horror, ColumnNum = 1, Id = 1 });
            modelBuilder.Entity<BookPlacement>().HasData(new BookPlacement { BookGenre = Genre.Fantasy, ColumnNum = 2, Id = 2 });
            modelBuilder.Entity<BookPlacement>().HasData(new BookPlacement { BookGenre = Genre.Fiction, ColumnNum = 3, Id = 3 });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookGenre = Genre.Fantasy,
                BookId = 12,
                Author = "JJ Fish",
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookGenre = Genre.Horror,
                BookId = 144,
                Author = "A Mirra",
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookGenre = Genre.Fiction,
                BookId = 1,
                Author = "Susan M",
            });
        }
    }
}

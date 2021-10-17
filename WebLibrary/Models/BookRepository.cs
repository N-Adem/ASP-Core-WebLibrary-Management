using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLibrary.Data;

namespace WebLibrary.Models
{
    public class BookRepository: IBookRepository
    {
        public AppDbContext _appDbContext;
        public BookRepository(AppDbContext appDbContext) 
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Book> AllBooks
        {
            get { return _appDbContext.Books; }
        }

        public Book GetBookById(int id)
        {
            return _appDbContext.Books.FirstOrDefault(b => b.BookId == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLibrary.Models
{
    public class MockBookRepository : IBookRepository
    {
        private readonly IPlacement _placementRepository = new MockPlacement();
        public IEnumerable<Book> AllBooks =>
            new List<Book>
            {
                new Book{ BookId = 1, Title = "Harry Potter"},
                new Book{ BookId = 2, Title = "Cooking Book"},
                new Book{ BookId = 5, Title = "The Exorsist"}
            };

        public Book GetBookById(int bookId) 
        {
            return AllBooks.FirstOrDefault(b => b.BookId == bookId);
        }
    }
}

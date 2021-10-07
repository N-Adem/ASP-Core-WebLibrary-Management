using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLibrary.Models
{
    public class MockPlacement: IPlacement
    {
        public IEnumerable<BookPlacement> AllOrder =>
            new List<BookPlacement>
            {
               new BookPlacement{ ColumnNum = 1, BookGenre = Genre.Fantasy},
               new BookPlacement{ ColumnNum = 2, BookGenre = Genre.Horror}
            };
    }
}

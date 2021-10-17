using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLibrary.Data;

namespace WebLibrary.Models
{
    public class BookPlacementRepository: IPlacement
    {
        public AppDbContext _appDbContext;
        public BookPlacementRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<BookPlacement> AllOrder
        {
            get 
            {
                return _appDbContext.BookPlacement.Include(bp => bp.ColumnNum);
            }
        }
    }
}

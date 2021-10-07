using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLibrary.Models
{
    public interface IPlacement
    {
        IEnumerable<BookPlacement> AllOrder { get; }
    }
}

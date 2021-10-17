using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebLibrary.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime YearPublished { get; set; }
        public string Publisher { get; set; }
        public Genre BookGenre { get; set; }
        public string Author { get; set; }
        public string ImgUrl { get; set; }
        public BookPlacement BookInfo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMinAPI.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public DateTime PublishDate { get; set; }
        public decimal BasePrice { get; set; }
        public Author? Author { get; set; }
        public int AuthorId { get; set; }

    }
}
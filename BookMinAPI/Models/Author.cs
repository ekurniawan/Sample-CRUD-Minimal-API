using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMinAPI.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        //public IEnumerable<Book>? Books { get; set; }
    }
}
using BookMvc.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMvc.Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PageNumber { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Category Category { get; set; }
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public List<Author_Book> Author_Books { get; set; }
    }
}

using System.Collections.Generic;
using System;

namespace DATA.Data.Entity
{
    public class Book : BaseEntity
    {
        public ICollection<Comment> Comments { get; set; }
        public string Bookname { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public DateTime PublishedDate { get; set; }
        public string Publisher { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<Score> Scores { get; set; }

    }
}

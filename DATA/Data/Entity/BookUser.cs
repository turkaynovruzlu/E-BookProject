﻿namespace DATA.Data.Entity
{
    public class BookUser : BaseEntity
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}

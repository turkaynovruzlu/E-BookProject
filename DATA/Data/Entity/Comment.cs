namespace DATA.Data.Entity
{
    public class Comment : BaseEntity
    {
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }
    }
}

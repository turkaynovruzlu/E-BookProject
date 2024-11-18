namespace DATA.Data.Entity
{
    public class Score : BaseEntity
    {
        public decimal Scores { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}

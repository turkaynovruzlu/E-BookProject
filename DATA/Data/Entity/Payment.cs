namespace DATA.Data.Entity
{
    public class Payment : BaseEntity
    {
        public int Price { get; set; }
        public string BookName { get; set; }
        public int Count { get; set; }
        public int TotalPrice { get; set; }
        public DateTime SaleDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}

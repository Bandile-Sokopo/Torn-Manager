namespace API.DTOs
{
    public class StockTransactionDto
    {
        public int Id { get; set; }
        public string Stock { get; set; }
        public DateTime DatePurchased { get; set; }
    }
}

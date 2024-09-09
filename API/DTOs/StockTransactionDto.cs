namespace API.DTOs
{
    public class StockTransactionDto
    {
        public string Stock { get; set; }
        public DateTime DatePurchased { get; set; }
        public int TotalPurchased { get; set; }
    }
}

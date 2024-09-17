namespace API.DTOs
{
    public class TradeDto
    {
        public DateOnly Date { get; set; }
        public string? Items { get; set; }
        public decimal AmountPaid { get; set; }
    }
}

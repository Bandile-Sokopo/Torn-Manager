namespace API.Entities
{
    public class TransactionHistory
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public string? Items { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal MarketValue { get; set; }

    }
}

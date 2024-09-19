namespace API.Entities
{
    public class Trade
    {
        public DateOnly Date { get; set; }
        public string Items { get; set; }
        public string customerName {  get; set; }
        public decimal AmountPaid { get; set; }
        public decimal MarketValue { get; set; }
    }
}

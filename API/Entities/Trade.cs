namespace API.Entities
{
    public class Trade
    {
        public DateOnly Date { get; set; }
        public List<string> Items { get; set; }
        public string customerName {  get; set; }
        public decimal AmountPaid { get; set; }
        public decimal MarketValue { get; set; }
    }
}

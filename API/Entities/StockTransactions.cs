using System;

namespace API.Entities
{
    public class StockTransactions
    {
        public int Id { get; set; }
        public string Stock {  get; set; }
        public DateTime DatePurchased { get; set; }
        public int Price { get; set; }
        public int TotalPurchased { get; set; }
    }
}

using System.Diagnostics;
using System.Text;
using API.Services.Transaction;

namespace API.Services.Transaction
{
    public class Transactions
    {
        private string tradeString { get; set; }
        private Prices priceList { get; set; }
        private Dictionary<string, decimal> itemList { get; set; }
        private string customerName;

        public Transactions(string tradeString, Prices priceList)
        {
            this.priceList = priceList;
            this.tradeString = tradeString;
        }
        public string TradeString
        {
            get {  return this.tradeString; }
            set { }
        }
        public Prices PriceList
        {
            get { return priceList; }
            set { }
        }
        public Dictionary<string, decimal> ItemList
        {
            get { return itemList; }
            set { itemList = priceList.PriceList; }
        }
        public string CustomerName
        {
            get { return tradeString.Substring(0, tradeString.IndexOf(" ")); }
            set { customerName = value; }
        }


    }
}

using System.Text;

namespace API.Services.Transaction
{
    public class TransactionService
    {
        private Transactions _transact;

        TransactionService(Transactions transaction)
        {
            _transact = transaction;
        }

        public Dictionary<string, int> getTradeList()
        {
            Dictionary<string, int> temp = new Dictionary<string, int>();

            _transact.TradeString.Remove(0, _transact.TradeString.IndexOf(" "));
            _transact.TradeString.Remove(0, _transact.TradeString.IndexOf(" "));

            _transact.TradeString = _transact.TradeString.Replace("x ", " ");
            _transact.TradeString = _transact.TradeString.Replace("to the trade.", "");

            string[] arr = _transact.TradeString.Split(", ");

            for (int i = 0; i < arr.Length; i++)
            {
                temp.Add(arr[i].Substring(arr[i].IndexOf(" ")), int.Parse(arr[i].Substring(0, arr[i].IndexOf(" "))));
            }

            return temp;
        }

        public decimal CalcAmount()
        {
            return _transact.ItemList.Sum(x => x.Value);
        }

        public string Receipt()
        {
            StringBuilder receipt = new StringBuilder();

            foreach (var x in _transact.ItemList)
            {
                receipt.Append($"Name: {x.Key} Quantity: {x.Value}");
            }

            return receipt.ToString();
        }
    }
}

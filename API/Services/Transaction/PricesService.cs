using API.Services.Transaction;

namespace API.Services.Transaction
{
    public class PricesService
    {

        private Prices _prices;

        PricesService(Prices prices)
        {
            _prices = prices;
        }
        void setPrices(decimal margin)
        {
            foreach (var item in _prices.MarketPrice.Items)
            {
                decimal price;
                price = item.Value.MarketValue - item.Value.MarketValue * margin;
                _prices.PriceList.Add(item.Value.Name, price);
            }
        }

        public Dictionary<string, decimal> getPrices() { return _prices.PriceList; }
    }
}

namespace API.Services.Transaction;

public class Prices
{
    private static ItemsResponse _marketPrice;
    private static Dictionary<string, decimal> priceList;
    private ClientRequest<ItemsResponse> request;

    public ItemsResponse MarketPrice
    {
        get {  return _marketPrice; }
        set { _marketPrice = value; }
    }

    public Dictionary<string, decimal> PriceList
    {
        get { return priceList; }
        set { }
    }
    public Prices(ItemsResponse marketPrice)
    {
        _marketPrice = marketPrice;
        priceList = new Dictionary<string, decimal>();
    }
}

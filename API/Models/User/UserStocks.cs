using Newtonsoft.Json;

public class StocksResponse
{
    [JsonProperty("stocks")]
    public Dictionary<int, UserStocks> stocks { get; set; } = new Dictionary<int, UserStocks>();
}

public class UserStocks
{
    [JsonProperty("stock_id")]
    public int StockId { get; set; }
    [JsonProperty("total_shares")]
    public int TotalShares { get; set; }
    [JsonProperty("transactions")]
    public Dictionary<int, Transactions> transaction { get; set; } = new Dictionary<int, Transactions>();
}

public class Transactions
{
    [JsonProperty("shares")]
    public int Shares { get; set; }
    [JsonProperty("bought_price")]
    public decimal Price { get; set; }
}
using Newtonsoft.Json;

public class Stocks
{
    [JsonProperty("stocks")]
    public Dictionary<int, Stock> stock { get; set; } = new Dictionary<int, Stock>();
}

public class Stock
{
    [JsonProperty("stock_id")]
    public int StockId { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; } = null!;
    [JsonProperty("acronym")]
    public string Acronym { get; set; } = null!;
    [JsonProperty("current_price")]
    public decimal CurrentPrice { get; set; }
    [JsonProperty("market_cap")]
    public decimal MarketCap { get; set; }
    [JsonProperty("total_shares")]
    public double TotalShares { get; set; }
    [JsonProperty("investors")]
    public int Investors { get; set; }
    [JsonProperty("benefit")]
    public Dictionary<int, Benefit> benefit { get; set; } = new Dictionary<int, Benefit>();
}

public class Benefit
{
    [JsonProperty("type")]
    public string Type { get; set; } = null!;
    [JsonProperty("Frequency")]
    public int Frequency { get; set; }
    [JsonProperty("requirement")]
    public decimal Requirement{ get; set; }
    [JsonProperty("description")]
    public string Description { get; set; } = null!;
}

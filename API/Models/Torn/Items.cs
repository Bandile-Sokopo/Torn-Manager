using Newtonsoft.Json;

public class ItemsResponse
{
    [JsonProperty("items")]
    public Dictionary<int, Item> Items { get; set; } = new Dictionary<int, Item>();
}

public class Item
{
    [JsonProperty("name")]
    public string Name { get; set; } = null!;
    [JsonProperty("description")]
    public string Description { get; set; } = null!;
    [JsonProperty("effect")]
    public string Effect { get; set; } = null!;
    [JsonProperty("requirement")]
    public string Requirement { get; set; } = null!;
    [JsonProperty("type")]
    public string Type { get; set; } = null!;
    [JsonProperty("weapon_type")]
    public string WeaponType { get; set; } = null!;
    [JsonProperty("buy_price")]
    public decimal BuyPrice { get; set; }
    [JsonProperty("sell_price")]
    public decimal SellPrice { get; set; }
    [JsonProperty("market_value")]
    public decimal MarketValue { get; set; }
    [JsonProperty("circulation")]
    public int Circulation { get; set; }
    [JsonProperty("image")]
    public string Image { get; set; } = null!;
}
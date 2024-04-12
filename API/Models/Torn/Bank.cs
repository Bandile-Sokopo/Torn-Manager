using Newtonsoft.Json;

public class Bank
{
    [JsonProperty("bank")]
    public Dictionary<int, Interest> stock { get; set; } = new Dictionary<int, Interest>();
}

public class Interest
{
    [JsonProperty("1w")]
    public int OneWeek { get; set; }
    [JsonProperty("2w")]
    public int TwoWeeks { get; set; }
    [JsonProperty("1m")]
    public int OneMonth {  get; set; }
    [JsonProperty("2m")]
    public int TwoMonths { get; set; }
    [JsonProperty("3m")]
    public int ThreeMonths { get; set; }
}

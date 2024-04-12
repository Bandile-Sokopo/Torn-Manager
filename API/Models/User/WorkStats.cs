using Newtonsoft.Json;

public class WorkStats
{
    [JsonProperty("manual_labor")]
    public int ManualLabor { get; set; }
    [JsonProperty("intelligence")]
    public int Intelligence { get; set; }
    [JsonProperty("endurance")]
    public int Endurance { get; set; }
}

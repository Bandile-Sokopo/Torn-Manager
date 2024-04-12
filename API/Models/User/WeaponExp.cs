using Newtonsoft.Json;

public class WeaponExp
{
    [JsonProperty("weaponexp")]
    public Dictionary<int, Weapon> weapon { get; set; } = new Dictionary<int, Weapon>();
}

public class Weapon
{
    [JsonProperty("itemID")]
    public int ItemId { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; } = null!;
    [JsonProperty("exp")]
    public int Exp { get; set; }
}

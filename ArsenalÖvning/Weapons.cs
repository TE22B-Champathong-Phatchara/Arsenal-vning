using System.Text.Json.Serialization;
public class Weapons
{
    [JsonInclude]
    public string Name;
    [JsonInclude]
    public int MinDmg;
    [JsonInclude]
    public int MaxDmg;
    
    public int Attack()
    {
        return Random.Shared.Next(MinDmg, MaxDmg + 1);
    }
}

using System.Collections.Generic;
using LiteDB;

public abstract class CocktailBase
{
    [BsonId]
    public int Id { get; set; }
    public string Name { get; set; }
    public List<string> Ingredients { get; set; }
    public TasteProfile Taste { get; set; }
    public AlcoholPreference AlcoholType { get; set; }
    public TemperaturePreference Temperature { get; set; }
    public SweetnessLevel Sweetness { get; set; }
    public abstract bool IsCreamy { get; }

    public abstract string GetTypeDescription(); 
}

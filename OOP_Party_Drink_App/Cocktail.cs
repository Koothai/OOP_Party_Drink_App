using System.Collections.Generic;
using LiteDB;


public class Cocktail
{
    public string Name { get; set; }
    public List<string> Ingredients { get; set; }
    public TasteProfile Taste { get; set; }
    public AlcoholPreference AlcoholType { get; set; }
    public TemperaturePreference Temperature { get; set; }
    public bool IsCreamy { get; set; }
    public SweetnessLevel Sweetness { get; set; }

    [BsonId]
    public int Id { get; set; }
}

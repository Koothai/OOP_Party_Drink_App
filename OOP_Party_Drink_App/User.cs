using LiteDB;
using System.Collections.Generic;

public class User
{
    [BsonId]
    public string Username { get; set; }
    public string Password { get; set; }

    public List<string> FavoriteCocktails { get; set; } = new List<string>();

    public TasteProfile Taste { get; set; }
    public AlcoholPreference Alcohol { get; set; }
    public TemperaturePreference Temperature { get; set; }
    public CreamyPreference Creamy { get; set; }
    public FlavorOpenness Adventurousness { get; set; }
    public List<string> DislikedFlavors { get; set; } = new List<string>();
    public Occasion DrinkOccasion { get; set; }
    public SweetnessLevel Sweetness { get; set; }
}

using LiteDB;
using System.Collections.Generic;
using System.Linq;

public class CocktailDatabase
{
    private readonly string _dbPath = "cocktails.db";

    public void SeedSampleCocktails()
    {
        using var db = new LiteDatabase(_dbPath);
        var collection = db.GetCollection<CocktailBase>("cocktails");

        if (collection.Count() == 0)
        {
            var cocktails = new List<CocktailBase>
            {
                new AlcoholicCocktail
                {
                    Name = "Cocktail #1",
                    Ingredients = new List<string> { "ice", "gin", "vodka" },
                    Taste = TasteProfile.Sweet,
                    AlcoholType = AlcoholPreference.Alcoholic,
                    Temperature = TemperaturePreference.RoomTemperature,
                    IsCreamy = false,
                    Sweetness = SweetnessLevel.MildlySweet
                },
                new NonAlcoholicCocktail
                {
                    Name = "Cocktail #2",
                    Ingredients = new List<string> { "ice", "mint" },
                    Taste = TasteProfile.Fruity,
                    AlcoholType = AlcoholPreference.NonAlcoholic,
                    Temperature = TemperaturePreference.Hot,
                    IsCreamy = false,
                    Sweetness = SweetnessLevel.VerySweet
                },
                new AlcoholicCocktail
                {
                    Name = "Cocktail #3",
                    Ingredients = new List<string> { "vodka", "coffee", "lime", "pineapple" },
                    Taste = TasteProfile.Bitter,
                    AlcoholType = AlcoholPreference.Alcoholic,
                    Temperature = TemperaturePreference.RoomTemperature,
                    IsCreamy = false,
                    Sweetness = SweetnessLevel.VerySweet
                },
                new AlcoholicCocktail
                {
                    Name = "Cocktail #4",
                    Ingredients = new List<string> { "strawberry", "gin", "pineapple", "rum", "vodka" },
                    Taste = TasteProfile.Balanced,
                    AlcoholType = AlcoholPreference.Alcoholic,
                    Temperature = TemperaturePreference.Cold,
                    IsCreamy = false,
                    Sweetness = SweetnessLevel.NotSweet
                },
                new NonAlcoholicCocktail
                {
                    Name = "Cocktail #5",
                    Ingredients = new List<string> { "vodka", "sugar" },
                    Taste = TasteProfile.Bitter,
                    AlcoholType = AlcoholPreference.NonAlcoholic,
                    Temperature = TemperaturePreference.Cold,
                    IsCreamy = true,
                    Sweetness = SweetnessLevel.VerySweet
                },
                new AlcoholicCocktail
                {
                    Name = "Cocktail #6",
                    Ingredients = new List<string> { "strawberry", "ice", "lime", "lemon", "whiskey" },
                    Taste = TasteProfile.Fruity,
                    AlcoholType = AlcoholPreference.Alcoholic,
                    Temperature = TemperaturePreference.Cold,
                    IsCreamy = false,
                    Sweetness = SweetnessLevel.NotSweet
                },
                new NonAlcoholicCocktail
                {
                    Name = "Cocktail #7",
                    Ingredients = new List<string> { "rum", "pineapple", "whiskey" },
                    Taste = TasteProfile.Sour,
                    AlcoholType = AlcoholPreference.NonAlcoholic,
                    Temperature = TemperaturePreference.Hot,
                    IsCreamy = true,
                    Sweetness = SweetnessLevel.VerySweet
                },
                new NonAlcoholicCocktail
                {
                    Name = "Cocktail #8",
                    Ingredients = new List<string> { "gin", "cream", "orange" },
                    Taste = TasteProfile.Sour,
                    AlcoholType = AlcoholPreference.NonAlcoholic,
                    Temperature = TemperaturePreference.RoomTemperature,
                    IsCreamy = false,
                    Sweetness = SweetnessLevel.NotSweet
                },
                new AlcoholicCocktail
                {
                    Name = "Cocktail #9",
                    Ingredients = new List<string> { "ice", "gin", "cream", "whiskey", "lime" },
                    Taste = TasteProfile.Sour,
                    AlcoholType = AlcoholPreference.Alcoholic,
                    Temperature = TemperaturePreference.Hot,
                    IsCreamy = true,
                    Sweetness = SweetnessLevel.NotSweet
                },
                new NonAlcoholicCocktail
                {
                    Name = "Cocktail #10",
                    Ingredients = new List<string> { "juice", "whiskey", "chocolate", "coffee", "rum" },
                    Taste = TasteProfile.Sour,
                    AlcoholType = AlcoholPreference.NonAlcoholic,
                    Temperature = TemperaturePreference.RoomTemperature,
                    IsCreamy = true,
                    Sweetness = SweetnessLevel.VerySweet
                }
            };

            collection.InsertBulk(cocktails);
        }
    }

    public List<CocktailBase> GetAllCocktails()
    {
        using var db = new LiteDatabase(_dbPath);
        return db.GetCollection<CocktailBase>("cocktails").FindAll().ToList();
    }
}

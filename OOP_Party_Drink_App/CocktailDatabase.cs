using LiteDB;
using System.Collections.Generic;
using System.Linq;

public class CocktailDatabase
{
    private readonly string _dbPath = "cocktails.db";

    public void SeedSampleCocktails()
    {
        using var db = new LiteDatabase(_dbPath);
        var collection = db.GetCollection<Cocktail>("cocktails");

        if (collection.Count() == 0)
        {
            var cocktails = new List<Cocktail>
            {
                 new Cocktail
{
    Name = "Cocktail #1",
    Ingredients = new List<string> { "ice", "gin", "vodka" },
    Taste = TasteProfile.Sweet,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = false,
    Sweetness = SweetnessLevel.MildlySweet
},
    new Cocktail
{
    Name = "Cocktail #2",
    Ingredients = new List<string> { "ice", "mint" },
    Taste = TasteProfile.Fruity,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = false,
    Sweetness = SweetnessLevel.VerySweet
},
    new Cocktail
{
    Name = "Cocktail #3",
    Ingredients = new List<string> { "vodka", "coffee", "lime", "pineapple" },
    Taste = TasteProfile.Bitter,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = false,
    Sweetness = SweetnessLevel.VerySweet
},
    new Cocktail
{
    Name = "Cocktail #4",
    Ingredients = new List<string> { "strawberry", "gin", "pineapple", "rum", "vodka" },
    Taste = TasteProfile.Balanced,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = false,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #5",
    Ingredients = new List<string> { "vodka", "sugar" },
    Taste = TasteProfile.Bitter,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = true,
    Sweetness = SweetnessLevel.VerySweet
},
    new Cocktail
{
    Name = "Cocktail #6",
    Ingredients = new List<string> { "strawberry", "ice", "lime", "lemon", "whiskey" },
    Taste = TasteProfile.Fruity,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = false,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #7",
    Ingredients = new List<string> { "rum", "pineapple", "whiskey" },
    Taste = TasteProfile.Sour,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = true,
    Sweetness = SweetnessLevel.VerySweet
},
    new Cocktail
{
    Name = "Cocktail #8",
    Ingredients = new List<string> { "gin", "cream", "orange" },
    Taste = TasteProfile.Sour,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = false,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #9",
    Ingredients = new List<string> { "ice", "gin", "cream", "whiskey", "lime" },
    Taste = TasteProfile.Sour,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = true,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #10",
    Ingredients = new List<string> { "juice", "whiskey", "chocolate", "coffee", "rum" },
    Taste = TasteProfile.Sour,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = true,
    Sweetness = SweetnessLevel.VerySweet
},
    new Cocktail
{
    Name = "Cocktail #11",
    Ingredients = new List<string> { "sugar", "coffee", "orange", "coconut", "juice" },
    Taste = TasteProfile.Sour,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = false,
    Sweetness = SweetnessLevel.VerySweet
},
    new Cocktail
{
    Name = "Cocktail #12",
    Ingredients = new List<string> { "sugar", "lemon", "coconut" },
    Taste = TasteProfile.Sour,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = true,
    Sweetness = SweetnessLevel.MildlySweet
},
    new Cocktail
{
    Name = "Cocktail #13",
    Ingredients = new List<string> { "gin", "pineapple", "vodka" },
    Taste = TasteProfile.Sweet,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = false,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #14",
    Ingredients = new List<string> { "blueberry", "gin", "tequila", "soda" },
    Taste = TasteProfile.Fruity,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = true,
    Sweetness = SweetnessLevel.MildlySweet
},
    new Cocktail
{
    Name = "Cocktail #15",
    Ingredients = new List<string> { "sugar", "coconut", "pineapple" },
    Taste = TasteProfile.Sour,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = false,
    Sweetness = SweetnessLevel.MildlySweet
},
    new Cocktail
{
    Name = "Cocktail #16",
    Ingredients = new List<string> { "ice", "vodka", "cream" },
    Taste = TasteProfile.Bitter,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = true,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #17",
    Ingredients = new List<string> { "soda", "coconut", "vodka" },
    Taste = TasteProfile.Sweet,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = false,
    Sweetness = SweetnessLevel.MildlySweet
},
    new Cocktail
{
    Name = "Cocktail #18",
    Ingredients = new List<string> { "coffee", "coconut", "ice", "lemon", "mint" },
    Taste = TasteProfile.Sweet,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = true,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #19",
    Ingredients = new List<string> { "soda", "coffee", "whiskey" },
    Taste = TasteProfile.Sour,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = true,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #20",
    Ingredients = new List<string> { "whiskey", "cream" },
    Taste = TasteProfile.Fruity,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = false,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #21",
    Ingredients = new List<string> { "gin", "rum", "tequila", "ice" },
    Taste = TasteProfile.Sour,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = true,
    Sweetness = SweetnessLevel.VerySweet
},
    new Cocktail
{
    Name = "Cocktail #22",
    Ingredients = new List<string> { "tequila", "cream", "vodka", "orange" },
    Taste = TasteProfile.Sour,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = true,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #23",
    Ingredients = new List<string> { "vodka", "tequila" },
    Taste = TasteProfile.Fruity,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = true,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #24",
    Ingredients = new List<string> { "ice", "lime" },
    Taste = TasteProfile.Bitter,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = false,
    Sweetness = SweetnessLevel.VerySweet
},
    new Cocktail
{
    Name = "Cocktail #25",
    Ingredients = new List<string> { "sugar", "orange", "coconut" },
    Taste = TasteProfile.Sweet,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = false,
    Sweetness = SweetnessLevel.MildlySweet
},
    new Cocktail
{
    Name = "Cocktail #26",
    Ingredients = new List<string> { "gin", "strawberry", "mint", "soda", "orange" },
    Taste = TasteProfile.Bitter,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = false,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #27",
    Ingredients = new List<string> { "gin", "sugar", "mint" },
    Taste = TasteProfile.Fruity,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = true,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #28",
    Ingredients = new List<string> { "whiskey", "pineapple" },
    Taste = TasteProfile.Sour,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = true,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #29",
    Ingredients = new List<string> { "gin", "whiskey", "soda" },
    Taste = TasteProfile.Fruity,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = true,
    Sweetness = SweetnessLevel.VerySweet
},
    new Cocktail
{
    Name = "Cocktail #30",
    Ingredients = new List<string> { "rum", "orange" },
    Taste = TasteProfile.Bitter,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = true,
    Sweetness = SweetnessLevel.VerySweet
},
    new Cocktail
{
    Name = "Cocktail #31",
    Ingredients = new List<string> { "ice", "coffee", "tequila" },
    Taste = TasteProfile.Balanced,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = true,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #32",
    Ingredients = new List<string> { "soda", "lime", "lemon" },
    Taste = TasteProfile.Bitter,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = true,
    Sweetness = SweetnessLevel.MildlySweet
},
    new Cocktail
{
    Name = "Cocktail #33",
    Ingredients = new List<string> { "soda", "lemon", "lime", "coconut" },
    Taste = TasteProfile.Sweet,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = false,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #34",
    Ingredients = new List<string> { "juice", "blueberry" },
    Taste = TasteProfile.Balanced,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = true,
    Sweetness = SweetnessLevel.MildlySweet
},
    new Cocktail
{
    Name = "Cocktail #35",
    Ingredients = new List<string> { "lemon", "chocolate" },
    Taste = TasteProfile.Fruity,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = false,
    Sweetness = SweetnessLevel.VerySweet
},
    new Cocktail
{
    Name = "Cocktail #36",
    Ingredients = new List<string> { "soda", "whiskey", "ice", "strawberry", "pineapple" },
    Taste = TasteProfile.Bitter,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = false,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #37",
    Ingredients = new List<string> { "rum", "coconut" },
    Taste = TasteProfile.Fruity,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = true,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #38",
    Ingredients = new List<string> { "strawberry", "sugar", "lemon" },
    Taste = TasteProfile.Bitter,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = false,
    Sweetness = SweetnessLevel.VerySweet
},
    new Cocktail
{
    Name = "Cocktail #39",
    Ingredients = new List<string> { "gin", "whiskey", "lime", "coconut", "chocolate" },
    Taste = TasteProfile.Bitter,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = true,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #40",
    Ingredients = new List<string> { "gin", "lime", "ice", "pineapple", "cream" },
    Taste = TasteProfile.Fruity,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = true,
    Sweetness = SweetnessLevel.MildlySweet
},
    new Cocktail
{
    Name = "Cocktail #41",
    Ingredients = new List<string> { "cream", "blueberry", "ice", "tequila", "mint" },
    Taste = TasteProfile.Sweet,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = false,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #42",
    Ingredients = new List<string> { "mint", "strawberry", "coconut", "pineapple", "lemon" },
    Taste = TasteProfile.Bitter,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = true,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #43",
    Ingredients = new List<string> { "cream", "mint", "pineapple" },
    Taste = TasteProfile.Sour,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = true,
    Sweetness = SweetnessLevel.MildlySweet
},
    new Cocktail
{
    Name = "Cocktail #44",
    Ingredients = new List<string> { "coconut", "cream", "ice", "pineapple" },
    Taste = TasteProfile.Sour,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = true,
    Sweetness = SweetnessLevel.MildlySweet
},
    new Cocktail
{
    Name = "Cocktail #45",
    Ingredients = new List<string> { "strawberry", "pineapple", "lime" },
    Taste = TasteProfile.Bitter,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = false,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #46",
    Ingredients = new List<string> { "gin", "cream", "chocolate", "mint" },
    Taste = TasteProfile.Balanced,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = true,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #47",
    Ingredients = new List<string> { "lemon", "strawberry", "soda" },
    Taste = TasteProfile.Balanced,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.RoomTemperature,
    IsCreamy = true,
    Sweetness = SweetnessLevel.MildlySweet
},
    new Cocktail
{
    Name = "Cocktail #48",
    Ingredients = new List<string> { "sugar", "pineapple", "blueberry", "lemon" },
    Taste = TasteProfile.Sour,
    AlcoholType = AlcoholPreference.Alcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = false,
    Sweetness = SweetnessLevel.VerySweet
},
    new Cocktail
{
    Name = "Cocktail #49",
    Ingredients = new List<string> { "lemon", "soda", "sugar", "whiskey" },
    Taste = TasteProfile.Balanced,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Hot,
    IsCreamy = false,
    Sweetness = SweetnessLevel.NotSweet
},
    new Cocktail
{
    Name = "Cocktail #50",
    Ingredients = new List<string> { "chocolate", "strawberry", "rum", "tequila", "whiskey" },
    Taste = TasteProfile.Sour,
    AlcoholType = AlcoholPreference.NonAlcoholic,
    Temperature = TemperaturePreference.Cold,
    IsCreamy = true,
    Sweetness = SweetnessLevel.NotSweet
}
            };

            collection.InsertBulk(cocktails);
        }
    }

    public List<Cocktail> GetAllCocktails()
    {
        using var db = new LiteDatabase(_dbPath);
        return db.GetCollection<Cocktail>("cocktails").FindAll().ToList();
    }
}

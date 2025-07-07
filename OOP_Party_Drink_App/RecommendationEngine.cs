using System.Collections.Generic;
using System.Linq;

public class RecommendationEngine
{
    public List<CocktailBase> Recommend(User user, List<CocktailBase> allCocktails)
    {
        var dislikedList = user.DislikedFlavors ?? new List<string>();

        var filtered = allCocktails
            .Where(c => !c.Ingredients.Any(ing =>
                dislikedList.Any(df => df.Equals(ing, System.StringComparison.OrdinalIgnoreCase))
            ))
            .Select(c => new
            {
                Cocktail = c,
                Score = GetMatchScore(user, c)
            })
            .OrderByDescending(x => x.Score)
            .Take(5) 
            .Select(x => x.Cocktail)
            .ToList();

        return filtered;
    }

    private int GetMatchScore(User user, CocktailBase c)
    {
        int score = 0;
        if (c.Taste == user.Taste) score += 2;
        if (c.AlcoholType == user.Alcohol) score += 2;
        if (c.Temperature == user.Temperature) score += 1;
        if (c.IsCreamy == (user.Creamy == CreamyPreference.Yes)) score += 1;
        if (c.Sweetness == user.Sweetness) score += 2;
        return score;
    }
}

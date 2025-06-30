using System.Collections.Generic;
using System.Linq;

public class RecommendationEngine
{
    public List<Cocktail> Recommend(User user, List<Cocktail> allCocktails)
    {
        // Eğer kullanıcı hiç beğenmediği flavor seçmemişse veya DislikedFlavors null ise, boş liste olarak kullan
        var dislikedList = user.DislikedFlavors ?? new List<string>();

        // Filtre: Kullanıcının beğenmediği flavorlardan hiçbirini içermeyen kokteyller
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
            .Take(5) // en iyi 5 kokteyl
            .Select(x => x.Cocktail)
            .ToList();

        return filtered;
    }

    // Skor mantığı: Kullanıcıya en uygun kokteyller öne çıkar
    private int GetMatchScore(User user, Cocktail c)
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

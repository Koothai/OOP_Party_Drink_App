public class NonAlcoholicCocktail : CocktailBase
{
    public override bool IsCreamy { get; set; }
    public override string GetTypeDescription() => "Non-Alcoholic Cocktail";
}
using LiteDB;
public class AlcoholicCocktail : CocktailBase
{
    public override bool IsCreamy { get; set; }
    public override string GetTypeDescription() => "Alcoholic Cocktail";
}

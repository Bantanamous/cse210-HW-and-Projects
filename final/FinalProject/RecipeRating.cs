public class RecipeRating
{
    private readonly Dictionary<string, int> _ratings = new Dictionary<string, int>();

    public void RateRecipe(string recipeName, int rating)
    {
        _ratings[recipeName] = rating;
    }
}

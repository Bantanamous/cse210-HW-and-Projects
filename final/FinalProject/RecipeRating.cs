public class RecipeRating
{
    private readonly Dictionary<string, int> _ratings = new Dictionary<string, int>();

    public void RateRecipe(string recipeName, int rating)
    {
        if (rating < 1 || rating > 5)
        {
            Console.WriteLine("Rating must be between 1 and 5.");
            return;
        }
        _ratings[recipeName] = rating;
    }

    public void DisplayRating(string recipeName)
    {
        if (_ratings.ContainsKey(recipeName))
            Console.WriteLine($"Rating: {_ratings[recipeName]}/5");
    }
}

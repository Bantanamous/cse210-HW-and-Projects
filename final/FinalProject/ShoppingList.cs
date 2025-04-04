public class ShoppingList
{
    private readonly Dictionary<string, List<string>> _recipeIngredients = new Dictionary<string, List<string>>();

    // add ingredients for a specific recipe
    public void AddIngredients(string recipeName, List<string> ingredients)
    {
        if (!_recipeIngredients.ContainsKey(recipeName))
        {
            _recipeIngredients[recipeName] = new List<string>();
        }
        _recipeIngredients[recipeName].AddRange(ingredients);
    }

    // To display shopping list for a specific recipe
    public void DisplayShoppingList(string recipeName)
    {
        if (_recipeIngredients.ContainsKey(recipeName))
        {
            Console.WriteLine($"Shopping List for {recipeName}:");
            foreach (var ingredient in _recipeIngredients[recipeName])
            {
                Console.WriteLine("- " + ingredient);
            }
        }
        else
        {
            Console.WriteLine("No shopping list found for this recipe.");
        }
    }
}
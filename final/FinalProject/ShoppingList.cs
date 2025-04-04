public class ShoppingList
{
    private readonly List<string> _ingredients = new List<string>();

    public void AddIngredients(List<string> ingredients)
    {
        _ingredients.AddRange(ingredients);
    }

    public void DisplayShoppingList()
    {
        if (_ingredients.Count == 0)
        {
            Console.WriteLine("Shopping list is empty.");
            return;
        }

        Console.WriteLine("Shopping List:");
        foreach (var item in _ingredients)
        {
            Console.WriteLine("- " + item);
        }
    }
}
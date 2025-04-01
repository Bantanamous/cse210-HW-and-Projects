class Recipe
{
    protected string _name;
    protected string _instructions;
    protected List<string> _ingredients;

    public Recipe(string name, List<string> ingredients, string instructions)
    {
        name = _name;
        ingredients = _ingredients;
        instructions = _instructions;
    }

    public virtual void DisplayRecipe()
    {
        Console.WriteLine($"Recipe: {_name}");
        Console.WriteLine($"Ingredients: {string.Join(", ", _ingredients)}");
        Console.WriteLine($"Instructions: {_instructions}");
    }

    public string GetName() => _name;
    public List<string> GetIngredients() => _ingredients;
}
public class Recipe
{
    protected string Name;
    protected List<string> Ingredients;
    protected string Instructions;

    public string GetName() => Name;
    public List<string> GetIngredients() => Ingredients;
    public string GetInstructions() => Instructions;

    public Recipe(string name, List<string> ingredients, string instructions)
    {
        Name = name;
        Ingredients = ingredients;
        Instructions = instructions;
    }

    public virtual void DisplayRecipe()
    {
        Console.WriteLine($"\nRecipe: {Name}\nIngredients: {string.Join(", ", Ingredients)}\nInstructions: {Instructions}\n");
    }
}
public class SauceRecipe : Recipe
{
    public SauceRecipe(string name, List<string> ingredients, string instructions) 
        : base(name, ingredients, instructions) {}

    public override void DisplayRecipe()
    {
        Console.WriteLine($"[Sauce] {Name}\nIngredients: {string.Join(", ", Ingredients)}\nInstructions: {Instructions}\n");
    }
}
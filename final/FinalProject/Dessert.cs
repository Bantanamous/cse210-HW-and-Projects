public class DessertRecipe : Recipe
{
    public DessertRecipe(string name, List<string> ingredients, string instructions) 
        : base(name, ingredients, instructions) {}

    public override void DisplayRecipe()
    {
        Console.WriteLine($"[Dessert] {Name}\nIngredients: {string.Join(", ", Ingredients)}\nInstructions: {Instructions}\n");
    }
}
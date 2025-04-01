class DessertRecipe : Recipe
{
    public DessertRecipe(string name, List<string> ingredients, string instructions)
        : base(name, ingredients, instructions) {}

    public override void DisplayRecipe()
    {
        Console.WriteLine($"Dessert Recipe:");
        base.DisplayRecipe();
    }
}
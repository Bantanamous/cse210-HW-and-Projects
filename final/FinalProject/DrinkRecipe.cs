class DrinkRecipe : Recipe
{
    
    public DrinkRecipe(string name, List<string> ingredients, string instructions)
    : base(name, ingredients, instructions) {}
    public override void DisplayRecipe()
    {
        Console.WriteLine($"drink Recipe: ");
        base.DisplayRecipe();
    }
}
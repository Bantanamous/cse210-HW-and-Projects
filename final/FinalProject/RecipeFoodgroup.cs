public class FoodGroupRecipe : Recipe
{
    public string FoodGroup { get; private set; }

    public FoodGroupRecipe(string name, List<string> ingredients, string instructions, string foodGroup) 
        : base(name, ingredients, instructions)
    {
        FoodGroup = foodGroup;
    }

    public override void DisplayRecipe()
    {
        Console.WriteLine($"[{FoodGroup}] {Name}\nIngredients: {string.Join(", ", Ingredients)}\nInstructions: {Instructions}\n");
    }
}
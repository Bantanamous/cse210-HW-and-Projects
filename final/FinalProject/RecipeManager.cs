public class RecipeManager
{
    private readonly List<Recipe> Recipes = new List<Recipe>();

    public void AddRecipe(Recipe recipe)
    {
        Recipes.Add(recipe);
        Console.WriteLine($"Added a {recipe.GetType().Name} to the manager.");
    }

    public List<Recipe> GetRecipes() => Recipes;

    public void DeleteRecipe(string name)
    {
        int removedCount = Recipes.RemoveAll(r => r.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));
        if (removedCount > 0)
            Console.WriteLine("Recipe deleted successfully.");
        else
            Console.WriteLine("Recipe not found.");
    }
}
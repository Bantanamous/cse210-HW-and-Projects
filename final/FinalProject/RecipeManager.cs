public class RecipeManager
{
    private readonly List<Recipe> Recipes = new List<Recipe>();

    public void AddRecipe(Recipe recipe)
    {
        Recipes.Add(recipe);
    }

    public void DisplayRecipes()
    {
        foreach (var recipe in Recipes)
        {
            recipe.DisplayRecipe();
        }
    }

    public void DeleteRecipe(string name)
    {
        Recipes.RemoveAll(r => r.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Recipe deleted successfully.");
    }
}
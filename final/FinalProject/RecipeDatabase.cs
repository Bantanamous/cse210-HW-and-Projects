public class RecipeDatabase
{
    private readonly string filePath = "recipes.txt";

    public void SaveRecipe(Recipe recipe)
    {
        File.AppendAllText(filePath, $"{recipe.GetName()}\nIngredients: {string.Join(", ", recipe.GetIngredients())}\nInstructions: {recipe.GetInstructions()}\n\n");
    }
    
    public List<Recipe> LoadRecipes()
    {
        List<Recipe> recipes = new List<Recipe>();
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            for (int i = 0; i < lines.Length; i += 4)
            {
                if (i + 2 < lines.Length)
                {
                    string name = lines[i];
                    List<string> ingredients = new List<string>(lines[i + 1].Replace("Ingredients: ", "").Split(", "));
                    string instructions = lines[i + 2].Replace("Instructions: ", "");
                    recipes.Add(new Recipe(name, ingredients, instructions));
                }
            }
        }
        return recipes;
    }
}
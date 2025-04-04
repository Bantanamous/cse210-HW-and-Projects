public class RecipeDatabase
{
    private readonly string filePath = "recipes.txt";

    public void SaveRecipe(Recipe recipe)
    {
        try
        {
            string type = recipe is DessertRecipe ? "Dessert" :
                          recipe is SauceRecipe ? "Sauce" :
                          recipe is FoodGroupRecipe fg ? $"FoodGroup:{fg.FoodGroup}" :
                          "General";
            File.AppendAllText(filePath, $"{type}\n{recipe.GetName()}\nIngredients: {string.Join(", ", recipe.GetIngredients())}\nInstructions: {recipe.GetInstructions()}\n\n");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving recipe: " + ex.Message);
        }
    }

    public List<Recipe> LoadRecipes()
    {
        List<Recipe> recipes = new List<Recipe>();
        try
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int i = 0; i < lines.Length; i += 5)
                {
                    if (i + 3 < lines.Length)
                    {
                        string typeLine = lines[i];
                        string name = lines[i + 1];
                        List<string> ingredients = new List<string>(lines[i + 2].Replace("Ingredients: ", "").Split(", "));
                        string instructions = lines[i + 3].Replace("Instructions: ", "");

                        Recipe recipe;
                        if (typeLine.StartsWith("FoodGroup:"))
                        {
                            string foodGroup = typeLine.Substring("FoodGroup:".Length);
                            recipe = new FoodGroupRecipe(name, ingredients, instructions, foodGroup);
                        }
                        else if (typeLine == "Dessert")
                        {
                            recipe = new DessertRecipe(name, ingredients, instructions);
                        }
                        else if (typeLine == "Sauce")
                        {
                            recipe = new SauceRecipe(name, ingredients, instructions);
                        }
                        else
                        {
                            recipe = new Recipe(name, ingredients, instructions);
                        }
                        recipes.Add(recipe);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading recipes: " + ex.Message);
        }
        return recipes;
    }
}
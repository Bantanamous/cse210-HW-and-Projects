using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        RecipeManager manager = new RecipeManager();
        RecipeDatabase database = new RecipeDatabase();
        RecipeNote notes = new RecipeNote();
        RecipeRating ratings = new RecipeRating();
        ShoppingList shoppingList = new ShoppingList();

        foreach (var recipe in database.LoadRecipes())
        {
            manager.AddRecipe(recipe);
        }

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. Display Recipes");
            Console.WriteLine("3. Delete Recipe");
            Console.WriteLine("4. Add Note to Recipe");
            Console.WriteLine("5. Rate a Recipe");
            Console.WriteLine("6. Show Shopping List for a Specific Recipe");
            Console.WriteLine("7. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    try
                    {
                        Console.Write("Enter recipe name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter ingredients (comma separated): ");
                        List<string> ingredients = new List<string>(Console.ReadLine().Split(", "));
                        shoppingList.AddIngredients(name, ingredients);

                        Console.Write("Enter instructions: ");
                        string instructions = Console.ReadLine();

                        Console.WriteLine("Select recipe type:");
                        Console.WriteLine("1. General");
                        Console.WriteLine("2. Dessert");
                        Console.WriteLine("3. Sauce");
                        Console.WriteLine("4. Food Group");
                        Console.Write("Your choice: ");
                        string typeChoice = Console.ReadLine();

                        Recipe newRecipe;
                        switch (typeChoice)
                        {
                            case "2":
                                newRecipe = new DessertRecipe(name, ingredients, instructions);
                                break;
                            case "3":
                                newRecipe = new SauceRecipe(name, ingredients, instructions);
                                break;
                            case "4":
                                Console.Write("Enter food group name: ");
                                string foodGroup = Console.ReadLine();
                                newRecipe = new FoodGroupRecipe(name, ingredients, instructions, foodGroup);
                                break;
                            default:
                                newRecipe = new Recipe(name, ingredients, instructions);
                                break;
                        }

                        manager.AddRecipe(newRecipe);
                        database.SaveRecipe(newRecipe);
                        Console.WriteLine("Recipe added successfully!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Failed to add recipe: " + ex.Message);
                    }
                    break;
                case "2":
                    var allRecipes = manager.GetRecipes();
                    if (allRecipes.Count == 0)
                    {
                        Console.WriteLine("No recipes to display.");
                        break;
                    }
                    foreach (var recipe in allRecipes)
                    {
                        recipe.DisplayRecipe();
                        notes.DisplayNote(recipe.GetName());
                        ratings.DisplayRating(recipe.GetName());
                        Console.WriteLine();
                    }
                    break;
                case "3":
                    Console.Write("Enter recipe name to delete: ");
                    string deleteName = Console.ReadLine();
                    manager.DeleteRecipe(deleteName);
                    break;
                case "4":
                    Console.Write("Enter recipe name to add a note: ");
                    string noteName = Console.ReadLine();
                    Console.Write("Enter your note: ");
                    string note = Console.ReadLine();
                    notes.AddNoteToRecipe(noteName, note);
                    Console.WriteLine("Note added successfully.");
                    break;
                case "5":
                    Console.Write("Enter recipe name to rate: ");
                    string rateName = Console.ReadLine();
                    Console.Write("Enter rating (1-5): ");
                    if (int.TryParse(Console.ReadLine(), out int rating))
                    {
                        ratings.RateRecipe(rateName, rating);
                        Console.WriteLine("Rating added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    }
                    break;
                case "6":
                    Console.Write("Enter recipe name to get the shopping list: ");
                    string shoppingRecipeName = Console.ReadLine();
                    shoppingList.DisplayShoppingList(shoppingRecipeName);
                    break;
                case "7":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
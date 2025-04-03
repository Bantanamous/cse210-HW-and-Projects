using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        RecipeManager manager = new RecipeManager();
        RecipeDatabase database = new RecipeDatabase();
        ShoppingList shoppingList = new ShoppingList();
        RecipeNote notes = new RecipeNote();
        RecipeRating ratings = new RecipeRating();

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Add Recipe");
            Console.WriteLine("2. Display Recipes");
            Console.WriteLine("3. Delete Recipe");
            Console.WriteLine("4. Add to Shopping List");
            Console.WriteLine("5. View Shopping List");
            Console.WriteLine("6. Add Note to Recipe");
            Console.WriteLine("7. Rate Recipe");
            Console.WriteLine("8. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter recipe name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter ingredients (comma separated): ");
                    List<string> ingredients = new List<string>(Console.ReadLine().Split(", "));
                    Console.Write("Enter instructions: ");
                    string instructions = Console.ReadLine();
                    Recipe newRecipe = new Recipe(name, ingredients, instructions);
                    manager.AddRecipe(newRecipe);
                    database.SaveRecipe(newRecipe);
                    Console.WriteLine("Recipe added successfully!");
                    break;
                case "2":
                    manager.DisplayRecipes();
                    break;
                case "3":
                    Console.Write("Enter recipe name to delete: ");
                    manager.DeleteRecipe(Console.ReadLine());
                    break;
                case "4":
                    Console.Write("Enter ingredients to add to shopping list (comma separated): ");
                    shoppingList.AddIngredients(new List<string>(Console.ReadLine().Split(", ")));
                    break;
                case "5":
                    shoppingList.DisplayShoppingList();
                    break;
                case "6":
                    Console.Write("Enter recipe name: ");
                    notes.AddNoteToRecipe(Console.ReadLine(), Console.ReadLine());
                    break;
                case "7":
                    Console.Write("Enter recipe name: ");
                    ratings.RateRecipe(Console.ReadLine(), int.Parse(Console.ReadLine()));
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
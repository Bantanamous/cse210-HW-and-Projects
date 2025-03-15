using System;
using System.Collections.Generic;
using System.Linq; // filters collections based on conditions
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Initialize the Scripture list class
        ScriptureList list = new ScriptureList();

        // Let user choose a scripture
        Scripture scripture = list.ChooseScripture();

        // Loop until all words hidden
        while (!scripture.AllHidden())
        {
            // Display the scripture with hidden words (if any)
            scripture.Display();

            // Prompt user to press Enter to hide a word or type 'quit' to exit
            Console.WriteLine("Press Enter to hide a random word, or type 'quit' to exit:");
            string userInput = Console.ReadLine().Trim();

            // Check if the user typed 'quit'
            if (userInput.ToLower() == "quit")
            {
                break;
            }

            // Hide random word 
            scripture.HideRandomWord(3); // Hides 3 random words

            // Clear the console and re-display the scripture
            Console.Clear();
        }

        if (scripture.AllHidden())
        {
            Console.WriteLine("All words have been hidden! The game is over.");
        }
        else
        {
            Console.WriteLine("You have quit the game.");
        }
    }
}

using System;
using System.IO;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;


// Resources used for this project include the provided helps from the class site, ChatGPT to explain new or misunderstood concepts and also check for consistancy with assignment requirements, and stack overflow

class Program
{
    static void Main(string[] args)
    {    
        Journal journal = new Journal();
        while(true)
        {
            // Menu selection            
            Console.WriteLine("\nPlease select one of the following:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save to File");
            Console.WriteLine("4. Load from File");
            Console.WriteLine("5. Exit");
            Console.Write("Enter the number of your selection: ");
            string selection = Console.ReadLine();
            Console.WriteLine();
            
            if (selection == "1")
            {
                PromptList promptList = new PromptList();
                string prompt = promptList.GetRandomPrompt(); //gets a random prompt from the prompt list
                Console.Write(prompt + " "); //writes prompt to terminal, leaves a space for user input
                string response = Console.ReadLine();
                Entry entry = new Entry(DateTime.Now, prompt, response);
                journal.AddEntry(entry); //adds entry to the journal class list
                entry.EntryDisplay();
            }
            else if (selection == "2")//display journal
            {
                journal.DisplayJournal();
            }
            else if (selection == "3")//save journal to file
            {
                Console.Write("Enter the name of the file you would like to save to (as a .txt): ");
                string journalName = Console.ReadLine();
                journal.SaveToFile($"{journalName}");
            }
            else if (selection == "4")// load journal from file
            {
                Console.Write("Enter the name of the file you would like to load from (as a .txt): ");
                string journalName = Console.ReadLine();
                journal.LoadFromFile($"{journalName}");
                // Console.WriteLine("Journal loaded.");
                journal.DisplayJournal();

            }
            else if (selection == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please try again.");
            }
        }
    }
}

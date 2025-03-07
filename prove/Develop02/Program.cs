using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {    
        // Menu selection
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load from File");
            Console.WriteLine("4. Save to File");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter the number of your selection:");
            string selection = Console.ReadLine();

            if (selection == "1")
            {
                PromptList promptList = new PromptList();
                string prompt = promptList.GetRandomPrompt();
                Console.WriteLine(prompt);
                string response = Console.ReadLine();
                Entry entry = new Entry(prompt, response);
                entry.EntryDisplay();
            }
            
    }
}
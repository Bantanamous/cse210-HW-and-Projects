using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Please enter a number: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4) //checks if input is a number and in necessary choice range
            {
                Console.WriteLine("Invalid choice, try again.");
                Thread.Sleep(1000); // delay to actually display the message
                continue;
            }

            if (choice == 4) //choice to exit program
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            if (choice == 1) // start breathing activity
                new Breathing().RunActivity();
            
            else if (choice == 2) // start reflection activity
                new Reflection().RunActivity();

            else if (choice == 3)
                new Listing().RunActivity();
        }
    }
}
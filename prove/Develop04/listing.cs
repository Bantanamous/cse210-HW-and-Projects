using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

class Listing : Activity
{
    public Listing() 
    :base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.") {}
    
    public void RunActivity()
    {
        // int elapsed = 0;
        int count = 0; // variable to keep track of number of responses listed 
        
        Start();
        
        Stopwatch stopwatch = Stopwatch.StartNew(); //new stopwatch object to track actual time. The .Startnew() begins it at this point.

        // list for the prompts
        string[] prompts = 
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "What are some things you enjoyed about this week?",
            "What were your biggest struggles this week?"
        };

        Random random = new Random();
        Console.WriteLine (prompts[random.Next(prompts.Length)]); // displays a random prompt from the list of prompts
        Pause(5); // pauses for 5 seconds

        while (stopwatch.Elapsed.TotalSeconds < _duration)
        {
            Console.Write("Enter a response: ");
            Console.ReadLine();
            count++;
            // elapsed += 2;
        }

        Console.WriteLine($"You listed {count} items.");
        
        stopwatch.Stop(); // stops stopwatch
        End();
    }

}
class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    
    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to {_name} Activity!");
        Console.WriteLine(_description);
        Console.Write("Enter duration (seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("\nPrepare to begin...");
        Pause(3); // short pause before starting
    }
    public void End()
    {
        Console.WriteLine("Congratulations, you have completed the activity!");
        Console.WriteLine($"You spent {_duration} seconds on this activity.");
        Thread.Sleep(3000); // short pause after ending
    }

    protected void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rCountdown: {i} "); // Overwrites previous output 
            Thread.Sleep(1000);
        }
        Console.WriteLine(); // Move to the next line
    }

}
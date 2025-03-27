class Menu
{
    public int DisplayMenu()
    {
        Console.WriteLine(); //Display Points
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        
        Console.Write("Please choose a number: ");
        return int.Parse(Console.ReadLine());
    }

    public int NewGoalMenu()
    {
        Console.WriteLine("The goal types are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        
        Console.Write("What goal would you like to make? ");
        return int.Parse(Console.ReadLine());
    }
}
class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Goals goals = new Goals("goals.txt");

        int userChoice;
        do
        {
            userChoice = menu.DisplayMenu(goals.TotalScore); // Use TotalScore property here

            switch (userChoice)
            {
                case 1:
                    int goalChoice = menu.NewGoalMenu();
                    CreateNewGoal(goalChoice, goals);
                    break;
                case 2:
                    goals.DisplayGoals();
                    break;
                case 3:
                    goals.SaveGoals();
                    break;
                case 4:
                    goals.LoadGoals();
                    break;
                case 5:
                    goals.RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        } while (userChoice != 6);
    }

    static void CreateNewGoal(int goalChoice, Goals goals)
    {
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter the number of points: ");
        int points = int.Parse(Console.ReadLine());

        Goal newGoal = null;

        switch (goalChoice)
        {
            case 1:
                newGoal = new Simple(name, description, points, false);
                break;
            case 2:
                newGoal = new Eternal(name, description, points);
                break;
            case 3:
                Console.Write("Enter the target count for completion: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                newGoal = new Checklist(name, description, points, false, targetCount, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                return;
        }

        goals.AddGoal(newGoal);
        Console.WriteLine("Goal created successfully!");
    }
}

class Goals
{
    protected string _filename;
    protected List<Goal> _goalsList = new List<Goal>();
    protected int _totalScore;

    private void ObtainFileName(string prompt)
    {
        Console.WriteLine(prompt);
        _filename = Console.ReadLine();
        if (string.IsNullOrEmpty(_filename)) // .isNullOrEmpty checks if the string is null or empty
        {
            Console.WriteLine("Filename cannot be empty. Please try again.");
            ObtainFileName(prompt); // Call the method again to get a valid filename
        }
  
    }
    public void AddGoal(Goal goal)
    {
        _goalsList.Add(goal);
    }
    public void LoadGoals()
    {

    }

    public void SaveGoals()
    {

    }
    public void DisplayGoals() //Review
    {
        Console.WriteLine("Here are your goals:");
        if (_goalsList.Count == 0)
        {
            Console.WriteLine("You have no goals yet.");
            return;
        }
        for (int i = 0; i < _goalsList.Count; i++)
        {
            Goal goal = _goalsList[i];
            string status = goal.getStatus() ? "Completed" : "Not Completed";
            Console.WriteLine($"{i + 1}. Name: {goal.GetName()}, Description: {goal.GetDescription()}, Status: {status}, Points: {goal.GetPoints()}, Type: {goal.GetGoalType()}");
        }
    }

    public void DisplayScore()
    {

    }
}
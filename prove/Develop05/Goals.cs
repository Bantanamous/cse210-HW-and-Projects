class Goals
{
    protected string _filename;
    protected List<Goal> _goalsList = new List<Goal>();
    protected int _totalScore;

    public Goals(string filename)
    {
        _filename = filename;
    }


    public void SetFileName(string filename)
    {
        _filename = filename;
    }

    public void AddGoal(Goal goal)
    {
        _goalsList.Add(goal);
    }
    public int TotalScore
    {
        get { return _totalScore; }
    }

    public void LoadGoals()
    {
        if (!File.Exists(_filename))
        {
            Console.WriteLine("File not found. Please check the filename and try again.");
            return;
        }

        _goalsList.Clear();  // Clears out the list before loading new goals
        string[] lines = File.ReadAllLines(_filename);

        if (!int.TryParse(lines[0], out _totalScore))
        {
            Console.WriteLine("Invalid score in file. Please check the file format.");
            return;
        }

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            switch (parts[0])
            {
                case "Simple":
                    _goalsList.Add(new Simple(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                    break;
                case "Eternal":
                    _goalsList.Add(new Eternal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "Checklist":
                    _goalsList.Add(new Checklist(
                        parts[1], // Name
                        parts[2], // Description
                        int.Parse(parts[3]), // Points
                        bool.Parse(parts[4]), // Status
                        int.Parse(parts[5]), // TargetCount
                        int.Parse(parts[6]), // Bonus
                        int.Parse(parts[7])  // TimesCompleted
                    ));
                    break;
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }



    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter(_filename))
        {
            writer.WriteLine(_totalScore);
            foreach (Goal goal in _goalsList)
            {
                if (goal is Checklist checklistGoal)
                {
                    writer.WriteLine($"{goal.GetGoalType()}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetStatus()}|{checklistGoal.GetTargetCount()}|{checklistGoal.GetBonus()}|{checklistGoal.GetTimesCompleted()}");
                }
                else
                {
                    writer.WriteLine($"{goal.GetGoalType()}|{goal.GetName()}|{goal.GetDescription()}|{goal.GetPoints()}|{goal.GetStatus()}");
                }
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Goals List:");
        if (_goalsList.Count == 0)
        {
            Console.WriteLine("No goals available.");
            return;
        }
        for (int i = 0; i < _goalsList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goalsList[i].ListGoal()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {_totalScore}");
    }

    public void RecordEvent()
    {
        DisplayGoals();
        Console.Write("Enter the number of the goal you completed: ");
        int choice = int.Parse(Console.ReadLine()) - 1;
        
        if (choice < 0 || choice >= _goalsList.Count)
        {
            Console.WriteLine("Invalid choice. Please try again.");
            return;
        }

        Goal selectedGoal = _goalsList[choice];

        if (selectedGoal is Checklist checklistGoal)
        {
            checklistGoal.MarkComplete();
            int pointsEarned = checklistGoal.GetPoints();

            if (checklistGoal.GetTimesCompleted() >= checklistGoal.GetTargetCount())
            {
                pointsEarned += checklistGoal.GetBonus(); // Add bonus points
            }

            _totalScore += pointsEarned;
            Console.WriteLine($"Progress updated: {checklistGoal.GetTimesCompleted()}/{checklistGoal.GetTargetCount()}");
            Console.WriteLine($"You earned {pointsEarned} points!");
        }
        else if (!selectedGoal.GetStatus()) 
        {
            selectedGoal.MarkComplete();
            _totalScore += selectedGoal.GetPoints();
            Console.WriteLine($"Goal {selectedGoal.GetName()} completed! You earned {selectedGoal.GetPoints()} points.");
        }
        else
        {
            Console.WriteLine($"Goal {selectedGoal.GetName()} is already completed.");
        }
    }



    // private string GetFileName(string prompt)
    // {
    //     Console.Write(prompt);
    //     return Console.ReadLine();
    // }
}

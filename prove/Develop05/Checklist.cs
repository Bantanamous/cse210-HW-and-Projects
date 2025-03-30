class Checklist : Goal
{
    private int _timesCompleted;
    private int _targetCount;
    private int _bonus;

    public Checklist(string name, string description, int points, bool status, int targetCount, int bonus, int timesCompleted)
        : base(name, description, points, status, "Checklist")
    {
        _targetCount = targetCount;
        _bonus = bonus;
        _timesCompleted = timesCompleted;
    }

    public override string ListGoal()
    {
        return $"[{(_status ? "X" : " ")}] {_name} ({_description}) -- {_numberOfPoints} points (Progress: {_timesCompleted}/{_targetCount} completions, Bonus: {_bonus} points)";
    }

    public override string GetGoalType() => "Checklist";

    public override void MarkComplete()
    {
        if (_timesCompleted < _targetCount)
        {
            _timesCompleted++;
            if (_timesCompleted >= _targetCount)
            {
                _status = true;
            }
        }
    }


    public int GetTotalPoints()
    {
        if (_status)
        {
            return _numberOfPoints + _bonus;
        }
        return _numberOfPoints;
    }

    public int GetTargetCount() => _targetCount;
    public int GetTimesCompleted() => _timesCompleted;
    public int GetBonus() => _bonus;

    public override int RecordEvent()
    {
        return 0;
    }

    public override void RunGoal(){}
}

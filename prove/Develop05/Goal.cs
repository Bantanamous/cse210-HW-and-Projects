abstract class Goal
{
    protected string _name;
    protected string _description;
    protected bool _status;
    protected string _goalType;
    protected int _numberOfPoints;

    public Goal(string name, string description, int points, bool status, string goalType)
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = status;
        _goalType = goalType;
    }

    public string GetName() => _name;
    public string GetDescription() => _description;
    public bool GetStatus() => _status;
    public int GetPoints() => _numberOfPoints;
    
    public virtual void MarkComplete()
    {
        _status = true;
    }

    public virtual string GetGoal() => _goalType;
    public virtual string GetGoalType() => _goalType;

    public virtual string ListGoal()
    {
        return $"[{(_status ? "X" : " ")}] {_name} ({_description}) -- {_numberOfPoints} points";
    }

    public override string ToString()
    {
        return $"{_goalType}|{_name}|{_description}|{_numberOfPoints}|{_status}";
    }

    public abstract int RecordEvent();
    public abstract void RunGoal();
}

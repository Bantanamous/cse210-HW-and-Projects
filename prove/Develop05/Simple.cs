class Simple : Goal
{
    public Simple(string name, string description, int points, bool status) : base(name, description, points, status, "Simple")
    {
        _name = name;
        _description = description;
        _numberOfPoints = points;
        _status = status;
        _goalType = "Simple";
    }
}
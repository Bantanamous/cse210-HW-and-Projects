class Simple : Goal
{
    public Simple(string name, string description, int points, bool status) : base(name, description, points, status, "Simple"){}

    public override void RunGoal(){}
    public override string GetGoal()
    {
        return base.GetGoal();
    }
    public override int RecordEvent()
    {
        return 0;
    }
}
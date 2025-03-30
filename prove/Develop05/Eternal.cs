class Eternal : Goal
{
    public Eternal(string name, string description, int points) : base(name, description, points, false, "Eternal") {}

    // Override MarkComplete to ensure goal remains incomplete (eternal)
    public override void MarkComplete()
    {
        // Do nothing, so goal remains "incomplete"
    }

    public override void RunGoal(){}

    public override int RecordEvent()
    {
        return 0;
    }
}

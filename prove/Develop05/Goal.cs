class Goal
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
}
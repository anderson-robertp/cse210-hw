public class Simple : Goal
{
    // Attributes

    // Constructor
    public Simple() : base(){}
    public Simple(string type) : base (type){

    }

    // Methods
    public override void SetGoal()
    {
        Console.WriteLine("");
        Console.Write("What is the name of your goal?");
        _name = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("What is a short description for the goal?");
        _desc = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("How many points for completing this goal?");
        _points = int.Parse(Console.ReadLine());
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
}
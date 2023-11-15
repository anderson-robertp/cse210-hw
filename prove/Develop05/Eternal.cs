public class Eternal : Goal
{
    // Attributes

    // Constructor
    public Eternal() : base(){}
    public Eternal(string type) : base(type){}
    public Eternal(string type,string name, string desc, int points) : base(type,name,desc,points){}

    // Methods
    public override void SetGoal(){
        Console.WriteLine("");
        Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("What is a short description for the goal? ");
        _desc = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("How many points for completing this goal? ");
        _points = int.Parse(Console.ReadLine());
    }
    public override int RecordEvent(){
        return _points;
    }
    public override string ToString(){
        string goal = $"{_type}:{_name},{_desc},{_points}";
        return goal;
    }
}
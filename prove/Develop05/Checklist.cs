public class Checklist : Goal {
    
    // Attributes
    protected int _bonusPoints;
    protected int _times;
    protected int _completed;

    // Constructor
    public Checklist() : base(){}
    public Checklist(string type) : base(type){}
    public Checklist(string type,string name, string desc, int points, int bonus, int times, int completed) : base(type,name,desc,points){
        _bonusPoints = bonus;
        _times = times;
        _completed = completed;
    }

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
        Console.WriteLine("");
        Console.Write("How many times does this goal need to be accomplished for bonus points? ");
        _times = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        Console.Write("How many bonus points for completing this goal that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        _completed = 0;        
    }
    public override void DisplayGoal(int count){
        if (_completed == _times){
            Console.WriteLine("");
            Console.Write($"{count}. [X] ");
        }
        else{
            Console.WriteLine("");
            Console.Write($"{count}. [ ] ");
        }
        Console.Write($"{_name} ({_desc}) -- Currently Completed {_completed}/{_times}");
    }
    public override int RecordEvent(){
        int totalPoints;
        _completed ++;
        if (_completed == _times){
           totalPoints = _points + _bonusPoints;
           _isComplete = true;
        }
        else{
            totalPoints = _points;
        }
        return totalPoints;
    }
    public override string ToString(){
        string goal = $"{_type}:{_name},{_desc},{_points},{_bonusPoints},{_times},{_completed}";
        return goal;
    }
}
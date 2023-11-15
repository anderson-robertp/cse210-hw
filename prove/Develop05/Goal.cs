public class Goal
{
    // Attributes
    protected string _name;
    protected string _desc;
    protected int _points;
    protected bool _isComplete;
    protected string _type;

    // Constructor
    public Goal(){}
    public Goal(string type){
        _type = type;
    }
    public Goal(string type,string name, string desc, int points, bool completed){
       // For Simple
        _type = type;
        _name = name;
        _desc = desc;
        _points = points;
        _isComplete = completed;
    }
    public Goal(string type, string name, string desc, int points){
        //For Eternal
        _type = type;
        _name = name;
        _desc = desc;
        _points = points;
    }
    
    
    
    // Methods
    public virtual void SetGoal(){}

    public virtual int RecordEvent(){
        int points = _points;
        return points;
    }

    public virtual void DisplayGoal(int count){
        if (_isComplete == true){
            Console.WriteLine("");
            Console.Write($"{count}. [X] ");
        }
        else{
            Console.WriteLine("");
            Console.Write($"{count}. [ ] ");
        }
        Console.Write($"{_name} ({_desc})");
    }
    public bool CheckComplete(){
        return false;
    }

    public virtual string ToString(){
        string goal = $"{_type}:{_name},{_desc},{_points},{_isComplete}";
        return goal;
    }
}
public class Assignments{
    // Variables
    protected string _studentName;
    private string _topic;

    // Constructors
    public Assignments(){

    }
    public Assignments(string studentName, string topic){
        _studentName = studentName;
        _topic = topic;
    }

    // Methods
    public void GetSummary(){
        Console.WriteLine($"{_studentName} - {_topic}");
    }

}


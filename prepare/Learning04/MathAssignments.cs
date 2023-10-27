using System.Reflection.PortableExecutable;

public class MathAssignments : Assignments{
    // Variables

    private string _textbookSection;
    private string _problems;

    // Constructor
    public MathAssignments(){

    }
    public MathAssignments(string student, string topic, string section, string problems) : base(student, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

        
    // Methods
    public void GetHomeworkList(){
        Console.WriteLine($"{_textbookSection} {_problems}");
    }
}
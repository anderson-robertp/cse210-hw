public class WritignAssignments : Assignments{
    // Variables
    private string _title;

    // Constructors
    public WritignAssignments(){}

    public WritignAssignments(string student, string topic, string title) : base(student, topic){
        _title = title;
    }

    //Methods
    public void GetWritingInformation(){
        Console.WriteLine($"{_title} by {_studentName}");
    }
}
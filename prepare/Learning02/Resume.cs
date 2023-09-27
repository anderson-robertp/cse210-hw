// Class for Resume information
public class Resume
{
    // Declare variables
    public string _name;
    public List<Job> _jobs = new List<Job>();


    // Constructor
    public Resume()
    {}

    // Methods
    public void DisplayResumeDetails()
    /*
    Method: Display resume details from member variables

    Variables: _name, List<_jobs>

    Returns: nothing
    */
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }
}
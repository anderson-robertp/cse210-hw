using System.Diagnostics.Contracts;

public class Job
{
   // Declare variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Constructor
    public Job()
    {

    }

    // Methods

    public void DisplayJobDetails()
    /*
    Method: Display job details from member variables

    Variables: _company, _jobTitle, _startYear, endYear

    Returns: nothing

    */
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
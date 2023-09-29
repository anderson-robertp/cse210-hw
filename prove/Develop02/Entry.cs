using System;

public class Entry
{
    // Declare variables
    public string _entry
    public string _prompt
    DateTime currentDate = DateTime.Today;
    string _date = currentDate;

    // Constructor
    public Entry()
    {}

    // Methods

    public entry ConstructEntry()
    {
        /*
        Method: Create entry from input

        Variables: _entry _prompt

        Returns: entry
        */

        Console.WriteLine($"{_prompt}")
        _entry = Console.Read();
        AddAnEntry()

    }

    public void DisplayEntry()
    {
        /*
        Method: Create entry from input

        Variables: _entry _prompt _date

        Returns: entry
        */
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_entry}");
    }
}
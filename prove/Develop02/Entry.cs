using System;
using System.Diagnostics.Contracts;

public class Entry
{
    // Declare variables
    public string _entry;
    public string _promptEntry;
    
    public string _date;

    // Constructor
    public Entry()
    {}

    // Methods

    public string ConstructEntry(_date, _promptEntry, _entry)
    {
        /*
        Method: Create entry from input

        Variables: _entry _prompt

        Returns: entry
        */
        
        
        
        return fullEntry;

    }

    public void DisplayEntry()
    {
        /*
        Method: Create entry from input

        Variables: _entry _prompt _date

        Returns: entry
        */
        
        Console.WriteLine($"Date: {_date} - Prompt: {_promptEntry}\n{_entry}");
    }
}
using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

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

    public string ConstructEntry(string date, string prompt, string entry)
    {
        /*
        Method: Create entry from input

        Variables: _entry _prompt

        Returns: entry
        */
        _date = date;
        _promptEntry = prompt;
        _entry = entry;

        string fullEntry = _date + "~|~" + _promptEntry + "~|~" + _entry; 
        
        
        
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
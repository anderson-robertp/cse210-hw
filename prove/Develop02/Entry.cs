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
    public Entry(){}
    public Entry(string date, string prompt, string entry){
        _date = date;
        _promptEntry = prompt;
        _entry = entry;
    }

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
        Console.WriteLine($"Entry Method ContructEntry var fullentry\n{fullEntry}");
        
        
        return fullEntry;

    }

    public void DisplayEntry()
    {
        /*
        Method: Create entry from input

        Variables: _entry _prompt _date

        Returns: entry
        */
        //string line = fromJournal.ToString();
        //string[] parts = line.Split("~|~");
        //string displayDate = parts[0];
        //string displayPrompt = parts[1]; //Index out of Range: look at contructentry and add to journal
        //string displayEntry = parts[2];
        Console.WriteLine($"Date: {_date} - Prompt: {_promptEntry}\n{_entry}");
    }
    public override string ToString(){
        string entryString = $"{_date},{_promptEntry},{_entry}";
        return entryString;
    }
}
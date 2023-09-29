using System;

public class Journal
{
    // Declare variables
    public List<Journal> _journal = new List<Journal>();

    // Constructor
    public Journal(){}

    // Methods

    public void AddAnEntry(entry)
    {
        /*
        Method: Adds entry to journal

        Variables: entry

        Returns: nothing
        */
        _journal.AddAnEntry(entry)

    }

    public void DisplayAllEntries()
    {
        /*
        Method: Display all entries from journal

        Variables: none

        Returns: nothing
        */
        foreach (Entry entry in _journal)
            {
                entry.DisplayEntry();
            }

    }

    public void LoadFromFile(filename);
    {
        /*
        Method: Loads journal from file

        Variables: filename

        Returns: nothing
        */
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (Entry entry in lines)
            {
                _journal.AddAnEntry(entry);
            }
    }

    public void SaveToFile(filename)
    {
        /*
        Method: saves journal to file

        Variables: filename

        Returns: nothing
        */
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _journal)
            {
                outputFile.WriteLine(entry);
            }
        }
    }
}
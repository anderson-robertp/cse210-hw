using System;

public class Journal
{
    // Declare variables
    public List<Entry> _journal = new List<Entry>();
    public Entry _entry = new Entry();
    

    // Constructor
    public Journal(){}

    // Methods

    public void AddAnEntry(Entry entry)
        {
            /*
            Method: Adds entry to journal

            Variables: entry

            Returns: nothing
            */
            _journal.Add(entry);

        }

    public void DisplayAllEntries()
        {
            /*
            Method: Display all entries from journal

            Variables: none

            Returns: nothing
            */
            foreach (Entry journalEntry in _journal)
                {
                    journalEntry.DisplayEntry();
                }

        }

    public void LoadFromFile(string filename)
        {
            /*
            Method: Loads journal from file

            Variables: filename

            Returns: nothing
            */
            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
                {
                    string[] parts = line.Split("~|~");
                    string _date = parts[0];
                    string _promptEntry = parts[1];
                    string _entryPart = parts[2];
                    // Construct entry
                    Entry entry = new Entry(_date,_promptEntry,_entryPart);
                    //add entry to journal
                    _journal.Add(entry);
                }
        }

    public void SaveToFile(string filename)
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
                string outEntry = entry.ToString();
                outputFile.WriteLine(outEntry);
            }
        }
    }
}
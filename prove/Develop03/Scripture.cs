using System.Runtime.InteropServices;

public class Scripture{
    //Tracks reference and text of the scripture, hides words in the scripture, and displays scripture.

    // Declare variables
    private Reference _reference = new Reference("John 3:16");
    private string _scripture = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
    private Boolean _isHidden = false;

    // Constructor
    public Scripture(){}

    // Methods
    public void DisplayScripture(){
        /*
        Method: Create entry from input

        Variables: _entry _prompt

        Returns: entry
        */
        _reference.DisplayReference();
        Console.WriteLine($"{_scripture}");
    }
    public void HideRandomWord(){
        /*
        Method: Create entry from input

        Variables: _entry _prompt

        Returns: entry
        */
    }

    public void IsCompletelyHidden(){
        /*
        Method: Create entry from input

        Variables: _entry _prompt

        Returns: entry
        */
    }

    public void LoadScripture(){
        /*
        Method: Create entry from input

        Variables: _entry _prompt

        Returns: entry
        */
    }
}
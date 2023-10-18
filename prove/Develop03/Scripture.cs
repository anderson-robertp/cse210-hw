using System.Runtime.InteropServices;

public class Scripture{
    //Tracks reference and text of the scripture, hides words in the scripture, and displays scripture.

    // Declare variables
    private Reference _reference;
    private string _scripture;
    private Boolean _isHidden = false;
    private List<Word> _words = new List<Word>();
    private Word _word;

    // Constructor
    public Scripture(){
        _reference.SetReference("John 3:16");
        _scripture = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        ConvertToList(_scripture);
    }

    public Scripture(string reference, string scripture){
        _reference.SetReference(reference);
        _scripture = scripture;
        ConvertToList(_scripture);
    }

    // Methods
    public void DisplayScripture(){
        /*
        Method: Displays Scripture

        Variables: 

        Returns: nothing
        */
        _reference.DisplayReference();
        Console.WriteLine($"{_words.ToString}");
    }
    
    public void HideRandomWord(){
        /*
        Method: hides a random word in the scripture

        Variables: 

        Returns: 
        */
    }

    public void IsCompletelyHidden(){
        /*
        Method: checks if the scripture i completely hidden and exits program

        Variables: 

        Returns: 
        */
    }

    public void LoadScripture(){
        /*
        Method: loads a file of scriptures

        Variables: 

        Returns: 
        */
    }

    private void ConvertToList(string scripture){
        string[] text = scripture.Split(' ');
        foreach (var word in text){
            _word.SetWord(word);
            _words.Add(_word);
        }
    }
}
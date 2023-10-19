using System.Runtime.InteropServices;

public class Scripture{
    //Tracks reference and text of the scripture, hides words in the scripture, and displays scripture.

    // Declare variables
    private Reference _reference = new Reference();
    private string _scripture;
    private Boolean _isHidden = false;
    private List<Word> _words = new List<Word>();
    private Word _word = new Word();
    Random rand = new Random();

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
        //Console.Write(" ");
        for (int i = 0; i < _words.Count; i++)
        {
            Console.Write(" ");
            _words[i].DisplayWord();
        }
        //Console.Write(".");
    }
    
    public void HideRandomWord(){
        /*
        Method: hides a random word in the scripture

        Variables: 

        Returns: 
        */
        
        int randI = rand.Next(0, _words.Count);
        Console.WriteLine($"{randI} {_words[randI]}");
        _words[randI].Hide();
        if (randI+1 < _words.Count() & randI+2 <= _words.Count()){
            _words[randI+1].Hide();
            _words[randI+2].Hide();
        }
        
        
    }

    public void IsCompletelyHidden(){
        /*
        Method: checks if the scripture if completely hidden and exits program

        Variables: 

        Returns: 
        */
        if (!_words.Contains(false));
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
        foreach (string word in text){
            _word = new Word();
            _word.SetWord(word);
            //Console.WriteLine($"{word}"); - For troubleshooting
            //_word.DisplayWord(); - For troubleshooting
            _words.Add(_word);
            
        }
    }
}
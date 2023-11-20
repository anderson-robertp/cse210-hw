using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

public class Scripture{
    //Tracks reference and text of the scripture, hides words in the scripture, and displays scripture.

    // Declare variables
    private Reference _reference = new Reference();
    private string _scripture;
    //private Boolean _isHidden = false;
    private List<Word> _words = new List<Word>();
    private Word _word = new Word();
    //private Random _rand = new Random();
    private int _randI;
    //private bool _used = true;
    private List<int> _usedRand = new List<int>();

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

        Variables: accepts no variables

        Returns: nothing
        */
        _reference.DisplayReference();
        //Console.Write(" "); - Testing
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

        Variables: accepts no variables

        Returns: none
        */
        
        
        _randI = PickRandom(_usedRand);
        if (_randI > 0){
            
            _words[_randI-1].Hide();
        }        
        //Console.WriteLine($"{_randI} {_words[_randI]}"); - for testing
        //if (_randI < _words.Count()){
        //    _words[_randI+1].Hide();
        //    _usedRand.Add(_randI+1);
        //}
        _words[_randI].Hide();
        
        if (_randI+1 < _words.Count()){
            _words[_randI+1].Hide();
            
        }
        
        
    }

    public string IsCompletelyHidden(){
        /*
        Method: checks if the scripture if completely hidden and exits program

        Variables: accepts no variables

        Returns: ifExit
        */
        int count = _words.Count();
        if (count <= _usedRand.Count()){
            foreach (Word item in _words)
            {
                item.Hide();
            }
            string ifExit = "exit";
            return ifExit;
        }
        else{
            string ifExit = "next";
            return ifExit;
        }
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

    private int PickRandom(List<int> randomList){
        //int rand;
        Random _rand = new Random();
        
        do {
            _randI = _rand.Next(0, _words.Count);
            
            
        } while (_usedRand.Contains(_randI));
        _usedRand.Add(_randI);
        int prev = _randI -1;
        _usedRand.Add(prev);
        int next = _randI+1;
        _usedRand.Add(next);
        return _randI;
        //string randString = Console.ReadLine();
        //int randI = int.Parse(randString);
        //return randI;
        
    }
}
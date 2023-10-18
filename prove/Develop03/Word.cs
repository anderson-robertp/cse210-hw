public class Word{
    //Tracks individual words and if they are hidden

    // Declare variables
    
    private Boolean _isHidden = false;
    private string _word;

    // Constructor
    public Word(string word){
        _word = word;
    }
    
    // Methods
        public string[] HideWord2(string[] wordList){
            /*
        Method: Create entry from input

        Variables: _entry _prompt

        Returns: entry
        */
        string[] hiddenWord = wordList;
        return hiddenWord;
        }

        public void SetWord(string word){
            _word = word;
        }

        public void DisplayWord(){
            Console.Write($"{_word} ");
        }
        
}

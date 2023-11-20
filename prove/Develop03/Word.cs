public class Word{
    //Tracks individual words and if they are hidden

    // Declare variables
    
    private Boolean _isHidden = false;
    private string _word;

    // Constructor
    public Word(string word){
        _word = word;
    }
    public Word(){}
    
    // Methods
        public void SetWord(string word){
            _word = word;
        }

        public void DisplayWord(){
            Console.Write(_word);
        }

        public void Hide(){
            if(_isHidden == false){
                char[] chars = _word.ToCharArray();
                for (int i = 0; i < chars.Length; i++)
                    {
                    //Console.Write(chars[i]); - for testing
                    chars[i] = '_';
                    //Console.WriteLine(chars[i]); - for testing
                    }
                string word = new string(chars);
                //Console.WriteLine(word); - for testing
                _isHidden = true;
                _word = word;
            }
            
        }
        
}

public class Reference{
    //Tracks book, chapter, and verse or verses.

    // Declare variables
    private string _book;
    private string _chapter;
    private int _verse;
    private int _endVerse;
    private string _reference;

    // Constructor
    public Reference(){
        // Plain constructor
        _book = "";
        _chapter = "";
        _verse = 1;
    }
    public Reference(string book, string chapter, int verse){
        //Constructor for a scripture with only one verse
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, string chapter, int verse, int endVerse){
        //Constructor for a scripture with multiple verses
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public Reference(string reference){
        _reference = reference;
    }

    // Methods
    //public Reference SetReference(string reference){


        /*
        Method: Create entry from input

        Variables: _entry _prompt

        Returns: entry
        */
        //List<string> ref = reference.Split(' ').ToList();
        //return _reference;    
    //}

    public void DisplayReference(){
        /*
        Method: Create entry from input

        Variables: _entry _prompt

        Returns: entry
        */
        if (_endVerse > 0){
            Console.WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse}");
        }
        else if (_verse>0){
            Console.WriteLine($"{_book} {_chapter}:{_verse}");
        }
        else{
            Console.WriteLine($"{_reference}");
        }
        
    }

}
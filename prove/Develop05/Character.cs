public class Character
{
    // Variables
    private int _points;
    private string _charClass;
    private int _level = 1;
    private bool _isSetup;
    private List<string> _classList = new List<string>(){
        "Artificer",
        "Barbarian",
        "Bard",
        "Cleric",
        "Druid",
        "Fighter",
        "Monk",
        "Paladin",
        "Ranger",
        "Sorcerer",
        "Warlock",
        "Wizard",
        };

    private int[] _xpArray = new int[] {
        0,      // Level 1
        300,    // Level 2
        900,    // Level 3
        2_700,  // Level 4
        6_500,  // Level 5
        14_000, // Level 6
        23_000, // Level 7
        34_000, // Level 8
        48_000, // Level 9
        64_000, // Level 10
        85_000, // Level 11
        100_000,// Level 12
        120_000,// Level 13
        140_000,// Level 14
        165_000,// Level 15
        195_000,// Level 16
        225_000,// Level 17
        265_000,// Level 18
        305_000,// Level 19
        355_000 // Level 20
    };

    // Constructor
    public Character(){}
    public Character(int points){
        _points = points;
    }
    public Character(int points, string charClass){
        _points = points;
        _charClass = charClass;
    }


    // Methods
    public void SetPoints(int points){
        _points += points;
    }

    public int GetPoints(){
        return _points;
    }

    public void SetUp(){
        int i = 1;
        foreach (var item in _classList)
        {
            Console.WriteLine($"  {i}. {item}");
            i++;
        }
        Console.WriteLine("");
        Console.Write("What class would you like to be? ");
        int charChoice = int.Parse(Console.ReadLine());
        _charClass = _classList[charChoice-1];

    }
    public string GetClass(){
        return _charClass;
    }
    public int GetLevel(){
        while ((_level < _xpArray.Length) && (_points > _xpArray[_level]))
        {
            _level++;
        }
        return _level;
    }
    public override string ToString(){
        string outChar = $"{_points},{_charClass}";
        return outChar;
    }
    public void Reset(int pnts, string charClass){
        _points = pnts;
        _charClass = charClass;
    }
}

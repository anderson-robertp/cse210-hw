public class Armor : LootItem{
    // Attributes
    protected string _defense;
    protected string _bonus;
    
    //Constructor
    public Armor() : base(){}
    public Armor(string name, string desc, string rarity, string defense, string bonus) : base(name,desc,rarity){
        _defense = defense;
        _bonus = bonus;
        _itemType = "armor";
    }

    //Methods
    public override void DisplayItem(){
        Console.WriteLine("");
        Console.WriteLine($"Name: {_name}, a {_rarity} Armor.");
        Console.WriteLine($"Bonus: {_bonus} Defense: {_defense}");
        Console.WriteLine($"{_desc}");
        Console.WriteLine("");
    }
    public override string ToString(){
        string itemString = $"{_itemType},{_name},{_desc},{_rarity},{_defense},{_bonus}";
        return itemString;
    }
}
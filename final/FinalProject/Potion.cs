public class Potion : LootItem{
    // Attributes
    protected string _healing;
    
    //Constructor
    public Potion() : base(){}
    public Potion(string name, string desc, string rarity, string healing) : base(name,desc,rarity){
        _healing = healing;
        _itemType = "potion";
    }

    //Methods
    public override void DisplayItem(){
        Console.WriteLine("");
        Console.WriteLine($"Name: {_name}, {_rarity} potion.");
        Console.WriteLine($"Healing: {_healing}");
        Console.WriteLine($"{_desc}");
        Console.WriteLine("");
    }
    public override string ToString(){
        string itemString = $"{_itemType},{_name},{_desc},{_rarity},{_healing}";
        return itemString;
    }
}
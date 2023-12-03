public class Armor : LootItem{
    // Attributes
    protected int _defense;
    protected int _bonus;
    
    //Constructor
    public Armor() : base(){}
    public Armor(string name, string desc, string rarity, int defense, int bonus) : base(name,desc,rarity){
        _defense = defense;
        _bonus = bonus;
        _itemType = "armor";
    }

    //Methods
    public override void DisplayItem(){
        Console.WriteLine($"Name: {_name} Rarity {_rarity}");
    }
    public override string ToString(){
        string itemString = "";
        return itemString;
    }
}
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
        Console.WriteLine($"Name: {_name} Rarity: {_rarity}");
        Console.WriteLine($"Bonus: {_bonus} Damage: {_defense}");
        Console.WriteLine($"{_desc}");
    }
    public override string ToString(){
        string itemString = $"{_itemType},{_name},{_desc},{_rarity},{_defense},{_bonus}";
        return itemString;
    }
}
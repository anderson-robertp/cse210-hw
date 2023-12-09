public class Weapon : LootItem{
    // Attributes
    protected string _damage;
    protected string _bonus;
    protected string _type;
    
    //Constructor
    public Weapon() : base(){}
    public Weapon(string name, string desc, string rarity, string damage, string bonus, string type) : base(name,desc,rarity){
        _damage = damage;
        _bonus = bonus;
        _type = type;
        _itemType = "weapon";
    }

    //Methods
    public override void DisplayItem(){
        Console.WriteLine($"Name: {_name} Rarity: {_rarity} {_type}");
        Console.WriteLine($"Bonus: {_bonus} Damage: {_damage}");
        Console.WriteLine($"{_desc}");
    }
    public override string ToString(){
        string itemString = $"{_itemType},{_name},{_desc},{_rarity},{_damage},{_bonus},{_type}";
        return itemString;
    }
}
public class Weapon : LootItem{
    // Attributes
    protected int _damage;
    protected int _bonus;
    protected string _type;
    
    //Constructor
    public Weapon() : base(){}
    public Weapon(string name, string desc, string rarity, int damage, int bonus, string type) : base(name,desc,rarity){
        _damage = damage;
        _bonus = bonus;
        _type = type;
        _itemType = "weapon";
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
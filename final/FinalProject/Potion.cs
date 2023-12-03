public class Potion : LootItem{
    // Attributes
    protected int _healing;
    
    //Constructor
    public Potion() : base(){}
    public Potion(string name, string desc, string rarity, int healing) : base(name,desc,rarity){
        _healing = healing;
        _itemType = "potion";
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
public abstract class LootItem{
    // Attributes
    protected String _name;
    protected String _desc;
    protected string _rarity;
    protected string _itemType;
    
    //Constructor
    public LootItem(){}
    public LootItem(string name, string desc, string rarity){
        _name = name;
        _desc = desc;
        _rarity = rarity;
        _itemType = "magicitem";
    }
    
    //Methods
    public virtual void DisplayItem(){
        Console.WriteLine($"Name: {_name} Rarity {_rarity}");
    }
    public override string ToString(){
        string itemString = "";
        return itemString;
    }
}






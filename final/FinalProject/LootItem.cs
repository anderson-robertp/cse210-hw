public class LootItem{
    // Attributes
    protected string _name;
    protected string _desc;
    protected string _rarity;
    protected string _itemType;
    
    //Constructor
    public LootItem(){}
    public LootItem(string name, string desc, string rarity){
        _name = name;
        _desc = desc;
        _rarity = rarity;
        _itemType = "item";
    }
    
    //Methods
    public virtual void DisplayItem(){
        Console.WriteLine($"Name: {_name} Rarity: {_rarity}");
        Console.WriteLine($"{_desc}");
    }
    public override string ToString(){
        string itemString = $"{_itemType},{_name},{_desc},{_rarity}";
        return itemString;
    }
}






public abstract class LootItem{
    // Attributes
    protected String _name;
    protected String _desc;
    protected string _rarity;
    


    
    //Constructor
    public LootItem(string name, string desc, string rarity){
        _name = name;
        _desc = desc;
        _rarity = rarity;
    }
    //Methods
}

public class Weapon : LootItem{
    // Attributes
    protected int _damage;
    protected int _bonus;
    
    //Constructor
    public Weapon(string name, string desc, string rarity, int damage, int bonus) : base(name,desc,rarity){
        _damage = damage;
        _bonus = bonus;
    }

    //Methods
}

public class Armor : LootItem{
    // Attributes
    protected int _defense;
    protected int _bonus;
    
    //Constructor
    public Armor(string name, string desc, string rarity, int defense, int bonus) : base(name,desc,rarity){
        _defense = defense;
        _bonus = bonus;
    }

    //Methods
}

public class Potion : LootItem{
    // Attributes
    protected int _healing;
    
    //Constructor
    public Potion(string name, string desc, string rarity, int healing) : base(name,desc,rarity){
        _healing = healing;
    }

    //Methods
}
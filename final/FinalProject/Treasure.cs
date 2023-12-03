public class Treasure{
    // Attributes
    protected List<(LootItem item, int weight)> _weapons = new List<(LootItem item, int weight)>();
    protected List<(LootItem item, int weight)> _armors = new List<(LootItem item, int weight)>();
    protected List<(LootItem item, int weight)> _potions = new List<(LootItem item, int weight)>();
    protected List<(LootItem item, int weight)> _magicItems = new List<(LootItem item, int weight)>();
    protected List<LootItem> _chest = new List<LootItem>();
    protected Weapon _weapon = new Weapon();


    //Constructor

    //Methods
    public virtual void AddWeapon(LootItem item, int weight){
        _weapons.Add((item,weight));
    }
    public virtual void AddArmor(LootItem item, int weight){
        _weapons.Add((item,weight));
    }
    public virtual void AddPotion(LootItem item, int weight){
        _weapons.Add((item,weight));
    }
    public virtual void AddMagicItem(LootItem item, int weight){
        _weapons.Add((item,weight));
    }
    public virtual void Roll(){
        int random = new Random().Next(1,100);
        // Tak random number and finds item
        
    }
}
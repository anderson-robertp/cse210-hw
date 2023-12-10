public class Rare : Treasure{
    // Attributes
    //private List<(LootItem item, int weight)> _common = new List<(LootItem item, int weight)>();

    //Constructor
    public Rare() : base(){}

    //Methods
    public override void RollChest()
    {
        Console.Clear();
        Console.WriteLine("This is the contents of a Rare chest");
        Weapon weapon = RollWeapon();
        Armor armor = RollArmor();
        Potion potion = RollPotion();
        LootItem lootItem = RollItem();
        weapon.DisplayItem();
        armor.DisplayItem();
        potion.DisplayItem();
        lootItem.DisplayItem();
    }
    public override Weapon RollWeapon()
    {
        //int totalWeight = _weapons.Sum(weapon => weapon.weight);
        int rand = new Random().Next(1,93);
        foreach (var(weapon, weight) in _weapons)
        {
            if (rand <= weight){
                return weapon;
            }
            rand -= weight;
            //weapon.DisplayItem();
        }
        // This should not happen if the weights are set up correctly
        throw new InvalidOperationException("Invalid loot table configuration."); 
    }
    public override Armor RollArmor()
    {
        //int totalWeight = _armors.Sum(armor => armor.weight);
        int rand = new Random().Next(1,93);
        foreach (var(armor, weight) in _armors)
        {
            if (rand <= weight){
                return armor;
            }
            rand -= weight;
            //weapon.DisplayItem();
        }
        // This should not happen if the weights are set up correctly
        throw new InvalidOperationException("Invalid loot table configuration.");
    }
    public override Potion RollPotion()
    {
        //int totalWeight = _potions.Sum(potion => potion.weight);
        int rand = new Random().Next(1,61);
        foreach (var(potion, weight) in _potions)
        {
            if (rand <= weight){
                return potion;
            }
            rand -= weight;
            //weapon.DisplayItem();
        }
        // This should not happen if the weights are set up correctly
        throw new InvalidOperationException("Invalid loot table configuration.");
    }
    public override LootItem RollItem()
    {
        //int totalWeight = _magicItems.Sum(item => item.weight);
        int rand = new Random().Next(1,91);
        foreach (var(item, weight) in _magicItems)
        {
            if (rand <= weight){
                return item;
            }
            rand -= weight;
            //weapon.DisplayItem();
        }
        // This should not happen if the weights are set up correctly
        throw new InvalidOperationException("Invalid loot table configuration.");
    }
}
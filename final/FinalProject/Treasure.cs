public class Treasure{
    // Attributes
    protected List<(Weapon weapon, int weight)> _weapons = new List<(Weapon weapon, int weight)>();
    protected List<(Armor armor, int weight)> _armors = new List<(Armor armor, int weight)>();
    protected List<(Potion potion, int weight)> _potions = new List<(Potion potion, int weight)>();
    protected List<(LootItem item, int weight)> _magicItems = new List<(LootItem item, int weight)>();
    protected List<LootItem> _chest = new List<LootItem>();
    //protected Weapon _weapon = new Weapon();


    //Constructor

    //Methods
    public virtual void AddWeapon(Weapon weapon, int weight){
        _weapons.Add((weapon,weight));
    }
    public virtual void AddArmor(Armor armor, int weight){
        _armors.Add((armor,weight));
    }
    public virtual void AddPotion(Potion potion, int weight){
        _potions.Add((potion,weight));
    }
    public virtual void AddMagicItem(LootItem item, int weight){
        _magicItems.Add((item,weight));
    }
    public virtual void Roll(){
        int random = new Random().Next(1,100);
        // Tak random number and finds item
        
    }
    public List<string> Export(){
        List<string> items = new List<string>();
        foreach((Weapon weapon, int weight) in _weapons){
            string weaponString = weapon.ToString() + "," + weight.ToString();
            items.Add(weaponString);
        }
        foreach((Armor armor, int weight) in _armors){
            string armorString = armor.ToString() + "," + weight.ToString();
            items.Add(armorString);
        }
        foreach ((Potion potion, int weight) in _potions)
        {
            string potionString = potion.ToString() + "," + weight.ToString();
            items.Add(potionString);
        }
        foreach ((LootItem item, int weight) in _magicItems)
        {
            string itemString = item.ToString() + "," + weight.ToString();
            items.Add(itemString);
        }
        return items;
    }
    public void Import(string[] items){
        foreach (var item in items)
        {
            string[] parts = item.Split(",");
            if (parts[0] == "weapon"){
                
                string name = parts[1];
                string desc = parts[2];
                string rarity = parts[3];
                string damage = parts[4];
                string bonus = parts[5];
                string type = parts[6];
                Weapon weapon = new Weapon(name,desc,rarity,damage,bonus,type);
                int weight = 0;
                _weapons.Add((weapon,weight));
            }
            else if (parts[0] == "armor")
            {
                string name = parts[1];
                string desc = parts[2];
                string rarity = parts[3];
                string defense = parts[4];
                string bonus = parts[5];
                Armor armor = new Armor(name,desc,rarity,defense,bonus);
                int weight = 0;
                _armors.Add((armor,weight));
            }
            else if (parts[0] == "potion")
            {
                string name = parts[1];
                string desc = parts[2];
                string rarity = parts[3];
                string healing = parts[4];
                Potion potion = new Potion(name,desc,rarity,healing);
                int weight = 0;
                _potions.Add((potion,weight));
            }
            else if (parts[0] == "magicItem")
            {
                string name = parts[1];
                string desc = parts[2];
                string rarity = parts[3];
                string damage = parts[4];
                string bonus = parts[5];
                string type = parts[6];
                Weapon weapon = new Weapon(name,desc,rarity,damage,bonus,type);
                int weight = 0;
                _weapons.Add((weapon,weight));
            }
        }
    }
    public void DisplayWeapons(){
        foreach (var (weapon,weight) in _weapons)
        {
            weapon.DisplayItem();
            Console.WriteLine($"Weight: {weight}");
        }
    }
    public void DisplayArmors(){
        foreach (var (armor,weight) in _armors)
        {
            armor.DisplayItem();
            Console.WriteLine($"Weight: {weight}");
        }
    }
    public void DisplayPotions(){
        foreach (var (potion,weight) in _potions)
        {
            potion.DisplayItem();
            Console.WriteLine($"Weight: {weight}");
        }
    }
    public void DisplayItems(){
        foreach (var (item,weight) in _magicItems)
        {
            item.DisplayItem();
            Console.WriteLine($"Weight: {weight}");
        }
    }
}
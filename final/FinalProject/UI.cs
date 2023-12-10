public class UI
{
    // Attributes

    // Constructor
    public UI(){}

    // Methods
    public int MainMenu(){
        int choice;
        
        Console.WriteLine("Please choose an action:");
        Console.WriteLine(" 1.Roll for Chest.");
        Console.WriteLine(" 2.Roll for Item");
        Console.WriteLine(" 3.Add an Item");
        Console.WriteLine(" 4.Load/Save Items"); // For testing
        Console.WriteLine(" 5.Display Items"); // For testing
        Console.WriteLine(" 6.Quit");
        Console.WriteLine("");
        Console.Write("What would you like to do? ");
        choice = int.Parse(Console.ReadLine());
        return choice;
    }
    public int AddMenu(){
        int choice;
        Console.WriteLine("Which type of item would you like to add?");
        Console.WriteLine(" 1.Weapon");
        Console.WriteLine(" 2.Armor");
        Console.WriteLine(" 3.Potion");
        Console.WriteLine(" 4.Magic Item");
        Console.WriteLine(" 5.Exit");
        Console.WriteLine("");
        Console.Write("What would you like to do? ");
        choice = int.Parse(Console.ReadLine());
        return choice;
    }
    public string ItemName(){
        Console.WriteLine("");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        return name;
    }
    public string ItemDesc(){
        Console.WriteLine("");
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        return desc;
    }

    public string ItemRarity(){
        Console.WriteLine("");
        Console.Write("Rarity: ");
        string rarity = Console.ReadLine();
        return rarity;
    }
    public string ItemBonus(){
        Console.WriteLine("");
        Console.Write("Bonus: ");
        string bonus = Console.ReadLine();
        return bonus;
    }

    public Weapon AddWeapon(){
        // Add Weapon
        Console.WriteLine("What are the weapon details?");
        //Name
        string name = ItemName();

        //Desc
        string desc = ItemDesc();

        //Rarity
        string rarity = ItemRarity();

        //Damage
        Console.WriteLine("");
        Console.Write("Damage: ");
        string damage = Console.ReadLine();

        //Bonus
        string bonus = ItemBonus();
                        
        //Type
        Console.WriteLine("");
        Console.Write("Weapon type: ");
        string type = Console.ReadLine();

        Weapon weapon = new Weapon(name,desc,rarity,damage,bonus,type);
        return weapon;
    }
    public Armor AddArmor(){
        // Add Armor
        Console.WriteLine("What are the armor details?");
        //Name
        string name = ItemName();

        //Desc
        string desc = ItemDesc();

        //Rarity
        string rarity = ItemRarity();
        
        //Defense
        Console.WriteLine("");
        Console.Write("Defense: ");
        string defense = Console.ReadLine();

        //Bonus
        string bonus = ItemBonus();

        Armor armor = new Armor(name,desc,rarity,defense,bonus);
        return armor;
    }
    public Potion AddPotion(){
        // Add Potion
        Console.WriteLine("What are the Potion details?");
        //Name
        string name = ItemName();

        //Desc
        string desc = ItemDesc();

        //Rarity
        string rarity = ItemRarity();

        //Healing
        Console.WriteLine("");
        Console.Write("Healing: ");
        string healing = Console.ReadLine();

        Potion potion = new Potion(name,desc,rarity,healing);
        return potion;
    }
    public LootItem AddItem(){
        Console.WriteLine("What are the item details?");
        //Name
        string name = ItemName();

        //Desc
        string desc = ItemDesc();

        //Rarity
        string rarity = ItemRarity();

        LootItem lootItem = new LootItem(name,desc,rarity);
        return lootItem;
    }
    public int RarityMenu(){
        
        Console.WriteLine(" 1.Common");
        Console.WriteLine(" 2.Uncommon");
        Console.WriteLine(" 3.Rare");
        Console.WriteLine(" 4.Legendary");
        Console.WriteLine(" 5.Exit");
        Console.WriteLine("");
        Console.Write("What would you like to do? ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
    public int ItemMenu(){
        Console.WriteLine("Select an option to roll for an item.");
        Console.WriteLine(" 1.Weapon");
        Console.WriteLine(" 2.Armor");
        Console.WriteLine(" 3.Potion");
        Console.WriteLine(" 4.Magic Item");
        Console.WriteLine(" 5.Exit");
        Console.WriteLine("");
        Console.Write("What would you like to do? ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
    
    
    public void DisplayMenu(){

    }
}
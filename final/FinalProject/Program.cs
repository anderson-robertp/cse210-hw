using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        int choice = 0;
        Treasure treasure = new Treasure();
        Uncommon uncommon = new Uncommon();
        Rare rare = new Rare();
        Legendary legendary = new Legendary();
        API api = new API();
        UI uI = new UI();
        
        // Load objects from API and sort them into tables
        
        string[] startItems = api.Load("items.txt"); // Preloading for testing
        treasure.Import(startItems);
        uncommon.Import(startItems);
        rare.Import(startItems);
        legendary.Import(startItems);

        
        while(choice != 6){
            Console.WriteLine("Welcome to Rollable Tables");
            Console.WriteLine("");
            
            choice = uI.MainMenu();

            if (choice == 1){
                choice = 0;
                while (choice != 5){
                    Console.WriteLine("Select an option to roll for a chest.");
                    choice = uI.RarityMenu();

                    if (choice == 1){
                        // Common Loot Chest
                        Console.WriteLine("Common Loot Chest");
                        treasure.RollChest();
                    }
                    else if (choice == 2){
                        // Uncommon Loot Chest
                        Console.WriteLine("UnCommon Loot Chest");
                        uncommon.RollChest();
                    }
                    else if (choice == 3){
                        // Rare Loot Chest
                        Console.WriteLine("Rare Loot Chest");
                        rare.RollChest();
                    }
                    else if (choice == 4){
                        // Legendary Loot Chest
                        Console.WriteLine("Legendary Loot Chest");
                        legendary.RollChest();
                    }
                    else if (choice == 5){
                        // Exit
                        
                    }
                    else {
                        Console.WriteLine("You done messed up, son.");
                    }
                }
                choice = 0;
            }
            else if (choice == 2){
                choice = 0;
                while (choice != 5){
                    
                    choice = uI.ItemMenu();

                    if (choice == 1){
                        // Weapon
                        
                        Console.WriteLine("Weapon");
                        Weapon weapon = legendary.RollWeapon();
                        weapon.DisplayItem();
                    }
                    else if (choice == 2){
                        // Armor
                        Console.WriteLine("Armor");
                        Armor armor = legendary.RollArmor();
                        armor.DisplayItem();
                    }
                    else if (choice == 3){
                        // Potion
                        Console.WriteLine("Potion");
                        Potion potion = legendary.RollPotion();
                        potion.DisplayItem();
                    }
                    else if (choice == 4){
                        // Magic Item
                        Console.WriteLine("Magic Item");
                        LootItem lootItem = legendary.RollItem();
                        lootItem.DisplayItem();

                    }
                    else if (choice == 5){}
                    else {
                        Console.WriteLine("You done messed up, son.");
                    }
                }
                choice = 0;
            }
            else if (choice == 3){
                choice = 0;
                while (choice != 5){
                    
                    choice = uI.AddMenu();

                    if (choice == 1){
                        // Add Weapon
                        Weapon weapon = uI.AddWeapon();
                        int weight = 0;
                        treasure.AddWeapon(weapon,weight);
                        Console.Clear();
                        Console.WriteLine("Weapon added.");
                        Thread.Sleep(3000);
                    }
                    else if (choice == 2){
                        // Add Armor
                        Armor armor = uI.AddArmor();
                        int weight = 0;
                        treasure.AddArmor(armor,weight);
                        Console.Clear();
                        Console.WriteLine("Armor added.");
                        Thread.Sleep(3000);
                        
                    }
                    else if (choice == 3){
                        // Add Potion
                        Potion potion = uI.AddPotion();
                        int weight = 0;
                        treasure.AddPotion(potion,weight);
                        Console.Clear();
                        Console.WriteLine("Potion added.");
                        Thread.Sleep(3000);
                        
                    }
                    else if (choice == 4){
                        // Add Item
                        Console.WriteLine("What are the item details?");
                        LootItem lootItem = uI.AddItem();
                        int weight = 0;
                        treasure.AddMagicItem(lootItem,weight);
                        Console.Clear();
                        Console.WriteLine("Item added.");
                        Thread.Sleep(3000);
                    }
                    
                }
                choice = 0;
            }
            else if (choice == 4){
                // Menu to Load or Save from a file.
                // For testing purposes
                Console.WriteLine("1)Load or 2)Save from File.");
                Console.WriteLine("For testing Purposes");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1){
                    Console.WriteLine("What is the name of the file?");
                    string filename = Console.ReadLine();
                    string[] items = api.Load(filename);
                    treasure.Import(items);
                }
                if (choice == 2){
                    Console.WriteLine("What is the name of the file?");
                    string filename = Console.ReadLine();
                    List<string> items = treasure.Export();
                    api.Save(items,filename);
                }
            }
            else if (choice == 5){
                // Display lists
                Console.WriteLine("Weapons");
                Console.WriteLine("");
                treasure.DisplayWeapons();
                Console.WriteLine("");
                Console.WriteLine("Armors");
                Console.WriteLine("");
                treasure.DisplayArmors();
                Console.WriteLine("");
                Console.WriteLine("Potions");
                Console.WriteLine("");
                treasure.DisplayPotions();
                Console.WriteLine("");
                Console.WriteLine("Items");
                treasure.DisplayItems();
            }
            else if (choice == 6){
                //Do nothing and quit
            }
            else{
                Console.WriteLine("You done messed up, son.");
            }
        }
        
    }
}
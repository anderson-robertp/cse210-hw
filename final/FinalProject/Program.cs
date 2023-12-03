using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        int choice = 0;
        Treasure treasure = new Treasure();
        // Load objects from API and sort them into tables
        
        while(choice != 5){
            Console.WriteLine("Welcome to Rollable Tables");
            Console.WriteLine("");
            Console.WriteLine("Please choose an action:");
            Console.WriteLine(" 1.Roll for Chest");
            Console.WriteLine(" 2.Roll for Item");
            Console.WriteLine(" 3.Add an Item");
            Console.WriteLine(" 4.Load/Save Items"); // For testing
            Console.WriteLine(" 5.Quit");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1){
                choice = 0;
                while (choice != 6){
                    
                    Console.WriteLine("Select an option to roll for a chest.");
                    Console.WriteLine(" 1.Common");
                    Console.WriteLine(" 2.Uncommon");
                    Console.WriteLine(" 3.Rare");
                    Console.WriteLine(" 4.Legendary");
                    Console.WriteLine(" 5.Random");
                    Console.WriteLine(" 6.Quit");
                    choice = int.Parse(Console.ReadLine());

                    if (choice == 1){
                        // Common Loot Chest
                        Console.WriteLine("Common Loot Chest");
                    }
                    else if (choice == 2){
                        // Uncommon Loot Chest
                        Console.WriteLine("UnCommon Loot Chest");
                    }
                    else if (choice == 3){
                        // Rare Loot Chest
                        Console.WriteLine("Rare Loot Chest");
                    }
                    else if (choice == 4){
                        // Legendary Loot Chest
                        Console.WriteLine("Legendary Loot Chest");
                    }
                    else if (choice == 5){
                        // Uncommon Loot Chest
                        Console.WriteLine("Random Loot Chest");
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
                    Console.WriteLine("Select an option to roll for an item.");
                    Console.WriteLine(" 1.Weapon");
                    Console.WriteLine(" 2.Armor");
                    Console.WriteLine(" 3.Potion");
                    Console.WriteLine(" 4.Magic Item");
                    Console.WriteLine(" 5.Quit");
                    choice = int.Parse(Console.ReadLine());

                    if (choice == 1){
                        // Weapon
                        Console.WriteLine("Weapon");
                    }
                    else if (choice == 2){
                        // Armor
                        Console.WriteLine("Armor");
                    }
                    else if (choice == 3){
                        // Potion
                        Console.WriteLine("Potion");
                    }
                    else if (choice == 4){
                        // Magic Item
                        Console.WriteLine("Magic Item");
                    }
                    else {
                        Console.WriteLine("You done messed up, son.");
                    }
                }
                choice = 0;
            }
            else if (choice == 3){
                choice = 0;
                while (choice != 5){
                    Console.WriteLine("Which type of item would you like to add?");
                    Console.WriteLine(" 1.Weapon");
                    Console.WriteLine(" 2.Armor");
                    Console.WriteLine(" 3.Potion");
                    Console.WriteLine(" 4.Magic Item");
                    Console.WriteLine(" 5.Quit");
                    choice = int.Parse(Console.ReadLine());

                    if (choice == 1){
                        // Add Weapon
                        //Console.WriteLine("What type of weapon?");
                        //string type = Console.ReadLine();
                        Console.WriteLine("Add Weapon");
                    }
                    else if (choice == 2){
                        // Add Armor
                        Console.WriteLine("Add Armor");
                    }
                    else if (choice == 3){
                        // Add Potion
                        Console.WriteLine("Add Potion");
                    }
                    else if (choice == 4){
                        // Add Magic Item
                        Console.WriteLine("Add Magic Item");
                    }
                    
                }
                choice = 0;
            }
            else if (choice == 4){
                // Menu to Load or Save from a file.
                // For testing purposes
                Console.WriteLine("Load or Save from File.");
                Console.WriteLine("For testing Purposes");
            }
            else if (choice == 5){
                //Do nothing and quit
            }
            else{
                Console.WriteLine("You done messed up, son.");
            }
        }
        
    }
}
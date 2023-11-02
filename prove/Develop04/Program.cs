using System;

class Program
{
    static void Main(string[] args)
    {
        Activity active = new Activity();
        Breath breath = new Breath();
        Reflect reflect = new Reflect();
        Listing listing = new Listing();
        int choice = 0;
        int seconds;

               
        while (choice != 4){
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            string choiceStr = Console.ReadLine();
            choice = Convert.ToInt32(choiceStr);
            if (choice == 1){
                active.Transition();
                seconds = breath.ActivityIntro(choice);
                breath.BreathingAct(seconds);
                
                active.Transition();
            }
            else if (choice == 2){
                active.Transition();
                seconds = reflect.ActivityIntro(choice);
                reflect.ReflectAct(seconds);
                active.Transition();
            }
            else if (choice == 3){
                active.Transition();
                seconds = listing.ActivityIntro(choice);
                listing.ListAct(seconds);
                active.Transition();

            }
            else if (choice == 4){
                break;
            }
            else{
                Console.WriteLine("Please enter a valid choice.");
            }

        }
    }
}
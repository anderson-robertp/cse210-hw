using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        int _points = 0;
        List<Goal> _goalList = new List<Goal>();
        List<Goal> _archive = new List<Goal>();
        string choice = "0";
        string goalChoice;
        int recordChoice;
        UI ui = new UI();

        // Program
        while (choice != "6"){
            
            // display point totals
            Console.WriteLine("");
            Console.WriteLine($"You have {_points} points.");
            Console.WriteLine("");

            // User Interface
            ui.DisplayMainMenu();

            // User Input
            Console.WriteLine("");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            // Goal Setting
            if (choice == "1"){
                ui.DisplayGoalMenu();
                Console.WriteLine("");
                Console.Write("Which type of goal would you like to make? ");
                goalChoice = Console.ReadLine();

                if (goalChoice == "1"){
                    Simple simple = new Simple("simple");
                    simple.SetGoal();
                    _goalList.Add(simple);
                    Thread.Sleep(2000);
                    
                }
                if (goalChoice == "2"){
                    Eternal eternal = new Eternal("eternal");
                    eternal.SetGoal();
                    _goalList.Add(eternal);
                    Thread.Sleep(2000);
                    
                }
                if (goalChoice == "3"){
                    Checklist checklist = new Checklist("checklist");
                    checklist.SetGoal();
                    _goalList.Add(checklist);
                    Thread.Sleep(2000);
                    
                }

            }
            else if (choice == "2"){
                int i = 1;
                foreach (Goal item in _goalList)
                {
                    item.DisplayGoal(i);
                    i++;
                }
                Console.WriteLine();
            }
            else if (choice == "3"){
                Console.WriteLine("save file");
                Thread.Sleep(10000);
            }
            else if (choice == "4"){
                Console.WriteLine("load file");
                Thread.Sleep(10000);
            }
            else if (choice == "5"){
                //remove a goal from list, it does not add points or complete goal
                // add to an archived list
                Console.WriteLine("achive goal");
                Thread.Sleep(10000);
            }
            else if (choice == "6"){
                int j = 1;
                foreach (Goal item in _goalList)
                {
                    item.DisplayGoal(j);
                    j++;
                }
                Console.WriteLine();
                Console.WriteLine("");
                Console.Write("Which goal would you like to record? ");
                recordChoice = int.Parse(Console.ReadLine());
                int k = 1;
                foreach (Goal item in _goalList)
                {
                    if(recordChoice == k){
                        _points += item.RecordEvent();
                    }
                    k++;
                }
            }
            else {}
        }  
    }
}
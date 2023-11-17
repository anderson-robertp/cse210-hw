using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables
        int points = 0;
        List<Goal> goalList = new List<Goal>();
        //List<Goal> archive = new List<Goal>();
        string choice = "0";
        string goalChoice;
        int recordChoice;
        UI ui = new UI();
        Character character = new Character();
        //string[] goalString;

        // Program
        while (choice != "7"){
            
            // display point totals
            Console.WriteLine("");
            Console.WriteLine($"Level {character.GetLevel()} {character.GetClass()}");
            Console.WriteLine($"You have {character.GetPoints()} points.");
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
                    goalList.Add(simple);
                    Thread.Sleep(2000);
                    
                }
                if (goalChoice == "2"){
                    Eternal eternal = new Eternal("eternal");
                    eternal.SetGoal();
                    goalList.Add(eternal);
                    Thread.Sleep(2000);
                    
                }
                if (goalChoice == "3"){
                    Checklist checklist = new Checklist("checklist");
                    checklist.SetGoal();
                    goalList.Add(checklist);
                    Thread.Sleep(2000);
                    
                }

            }
            // Display Goals
            else if (choice == "2"){
                int i = 1;
                foreach (Goal item in goalList)
                {
                    item.DisplayGoal(i);
                    i++;
                }
                Thread.Sleep(3000);
                Console.WriteLine();
            }
            // Save to File
            else if (choice == "3"){
                Console.WriteLine("");
                Console.Write("What filename would you like to save as? ");
                string filename = Console.ReadLine();
                //string[] goalString;
                List<string> goalString = new List<string>();
                File file = new File();
                foreach (Goal item in goalList)
                {
                    string convert = item.ToString();
                    goalString.Add(convert);
                }
                string outChar = character.ToString();
                file.SaveToFile(outChar,goalString,filename);
                
            }
            // Load from file
            else if (choice == "4"){
                Console.WriteLine("");
                Console.Write("What filename would you like to open? ");
                string filename = Console.ReadLine();
                File file = new File();
                string[] goals = file.LoadFromFile(filename);
                string inChar = goals[0];
                string[] charParts = inChar.Split(",");
                int pnts = int.Parse(charParts[0]);
                string inClass = charParts[1];
                character.Reset(pnts,inClass);
                
                goalList = file.ConvertToGoals(goals);

                /* Moved to File class
                foreach(string line in goals.Skip(1)){
                    string [] parts = line.Split(":");
                    string type = parts[0];
                    string[] goal = parts[1].Split(",");
                    if(type == "simple"){
                        string name = goal[0];
                        string desc = goal[1];
                        int pnts= int.Parse(goal[2]);
                        bool complete = bool.Parse(goal[3]);
                        Simple simp = new Simple(type,name,desc,pnts,complete);
                        goalList.Add(simp);
                    }
                    else if(type == "eternal"){
                        string name = goal[0];
                        string desc = goal[1];
                        int pnts= int.Parse(goal[2]);
                        Eternal eter = new Eternal(type,name,desc,pnts);
                        goalList.Add(eter);
                    }
                    else if(type == "checklist"){
                        string name = goal[0];
                        string desc = goal[1];
                        int pnts= int.Parse(goal[2]);
                        int bonus = int.Parse(goal[3]);
                        int times = int.Parse(goal[4]);
                        int completed = int.Parse(goal[5]);
                        Checklist check = new Checklist(type,name,desc,pnts,bonus,times,completed);
                        goalList.Add(check);
                    }

                }
                */
            }
            // Set Character
            else if (choice == "5"){
                character.SetUp();
            }
            // Record Event
            else if (choice == "6"){
                int j = 1;
                foreach (Goal item in goalList)
                {
                    item.DisplayGoal(j);
                    j++;
                }
                Console.WriteLine();
                Console.WriteLine("");
                Console.Write("Which goal would you like to record? ");
                recordChoice = int.Parse(Console.ReadLine());
                int k = 1;
                int level = character.GetLevel();
                foreach (Goal item in goalList)
                {
                    if(recordChoice == k){
                        int temp = item.RecordEvent();
                        character.SetPoints(temp);
                    }
                    k++;
                }
                Console.WriteLine();
                Console.WriteLine("Good job! You've completed a goal!");
                Console.WriteLine();
                if (character.GetLevel() > level)
                {
                    Console.WriteLine("Congrats! You leveled up!");
                }
                Thread.Sleep(3000);
            }
            else {}
        }  
    }
}
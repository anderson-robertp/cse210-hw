using System;
using System.Security.Cryptography.X509Certificates;
//using System.Net;
//using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
       var quit = false;
       DateTime theCurrentTime = DateTime.Now;
       string dateText = theCurrentTime.ToShortDateString();
       PromptGenerator prompt = new PromptGenerator();
       Entry entry = new Entry();
       Journal journal = new Journal();
        

        while (quit != true)
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.WriteLine("What would you like to do?");
            int option = Console.Read();

            if (option == 1){
                //Write
                
                
                string query = prompt.GeneratePrompt();
                Console.WriteLine($"{query}");
                string input = Console.ReadLine();
                entry.ConstructEntry(dateText, query, input);
                journal.AddAnEntry(entry);
            }
            else if (option == 2){
                //Display
                journal.DisplayAllEntries();
                
            }
            else if (option == 3 ){
                //Load file
                Console.WriteLine("Please enter a file name: i.e. journal.txt:");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);

            }
            else if (option == 4){
                //Save File
                Console.WriteLine("Please enter a name to save the file: i.e. journal.txt");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if ( option == 5){
                quit = true;
            }
            else {
                Console.WriteLine("Please enter a number between 1 and 5.");
                Console.WriteLine(" ");
            }
        }
    }
}
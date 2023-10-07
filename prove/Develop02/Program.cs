using System;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Reflection.Emit;

class Program
{
    static void Main(string[] args)
    {
       var quit = false;
       DateTime theCurrentTime = DateTime.Now;
       string dateText = theCurrentTime.ToShortDateString();
       PromptGenerator promptClass = new PromptGenerator();
       Entry entryClass = new Entry();
       Journal journalClass = new Journal();

        

        while (quit != true)
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.WriteLine("What would you like to do?");
            string option = Console.ReadLine();

            if (option == "1"){
                //Write
                // Note loading individual entries in to journal or not displaying the correctly
                
                string query = promptClass.GeneratePrompt();
                Console.WriteLine($"{query}");
                string input = Console.ReadLine();
                string fullEntry = entryClass.ConstructEntry(dateText, query, input);
                Console.WriteLine($"Main - variable entry:{fullEntry}");
                journalClass.AddAnEntry(fullEntry);
            }
            else if (option == "2"){
                //Display
                journalClass.DisplayAllEntries();
                
            }
            else if (option == "3"){
                //Load file
                Console.WriteLine("Please enter a file name: i.e. journal.txt:");
                string filename = Console.ReadLine();
                journalClass.LoadFromFile(filename);

            }
            else if (option == "4"){
                //Save File
                //Only saving the word entry not he actually entry
                Console.WriteLine("Please enter a name to save the file: i.e. journal.txt");
                string filename = Console.ReadLine();
                journalClass.SaveToFile(filename);
            }
            else if ( option == "5"){
                quit = true;
            }
            else {
                Console.WriteLine("Please enter a number between 1 and 5.");
                Console.WriteLine(" ");
            }
        }
    }
}
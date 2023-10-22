using System;

class Program
{
    static void Main(string[] args)
    {
        string exit = "noquit";
        Scripture scrip = new Scripture();

        while (exit != "quit"){
            // Clear Console
            Console.Clear();
            
            // Call Display Scripture
            scrip.DisplayScripture();
            
            //Write blank line nd instructions
            Console.WriteLine("");
            Console.WriteLine("Press enter or type quit to exit");
            
            // Read user inpuit
            exit = Console.ReadLine();

            //Call check within scripture class if it is completely hidden
            //Store variable from method to determine what to do next
            string next = scrip.IsCompletelyHidden();
            
            //Id not completely hidden, hide next word
            if (next == "next"){
                scrip.HideRandomWord();
            }
            //Else quit program
            else{
                Console.WriteLine("The scripture is completely hidden.");
                exit = "quit";
            }
            
        }
    }
}
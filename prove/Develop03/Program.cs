using System;

class Program
{
    static void Main(string[] args)
    {
        string exit = "noquit";
        Scripture scrip = new Scripture();

        while (exit != "quit"){
            Console.Clear();
            scrip.DisplayScripture();
            Console.WriteLine("");
            Console.WriteLine("Press enter or type quit to exit");
            exit = Console.ReadLine();
            string next = scrip.IsCompletelyHidden();
            if (next == "next"){
                scrip.HideRandomWord();
            }
            else{
                exit = "quit";
            }
            
        }
    }
}
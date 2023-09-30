using System;

class Program
{
    static void Main(string[] args)
    {
       var quit = false;
       DateTime currentDate = DateTime.Today;
        

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
                string query = ;
                Console.WriteLine($"{query}");
                
            }
            else if (option == 2){
                //Display
            }
            else if (option == 3 ){
                //Load file
            }
            else if (option == 4){
                //Save File
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
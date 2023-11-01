public class Activity{
    //Variables
    protected int _duration;
    //Constructor

    //Methods
    public void ActivityIntro(int choice){
        Console.Clear();
        if (choice == 1){
            Console.WriteLine("Welcome to the Breathing Activity.");
            Console.WriteLine("");
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            SetDuration();
        }
        else if (choice == 2){
            Console.WriteLine("Welcome to the Reflecting Activity.");
            Console.WriteLine("");
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            SetDuration();
        }
        else if (choice == 3){
            Console.WriteLine("Welcome to the Listing Activity.");
            Console.WriteLine("");
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            SetDuration();
        }
    }

    public void ActivityOutro(){

    }
    public void SetDuration(){
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like you session?");
        string secondsStr = Console.ReadLine();
        int seconds = Convert.ToInt32(secondsStr);
        _duration = seconds;
    }
    public void Transition(){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(10);

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.Write("+");

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        }
    }
}
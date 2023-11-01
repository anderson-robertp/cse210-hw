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
            Console.WriteLine("This activity works on breating.");
            SetDuration();
        }
        else if (choice == 2){
            Console.WriteLine("Welcome to the Reflecting Activity.");
            Console.WriteLine("");
            Console.WriteLine("This activity works on reflecting.");
            SetDuration();
        }
        else if (choice == 3){
            Console.WriteLine("Welcome to the Listing Activity.");
            Console.WriteLine("");
            Console.WriteLine("This activity works on listing.");
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
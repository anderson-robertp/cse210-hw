public class Activity{
    
    //Variables
    protected int _duration;
    private string _activity;
    private List<string> _animationList = new List<string>(){
        "|","/","-","\\","|","/","-","\\"
    };
    protected int _choice;
    
    //Constructor
    public Activity(){}

    public Activity(int choice){}

    //Methods
    public int ActivityIntro(int choice){
        Console.Clear();
        int time;
        _choice = choice;
        if (_choice == 1){
            Console.WriteLine("Welcome to the Breathing Activity.");
            Console.WriteLine("");
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            
        }
        else if (_choice == 2){
            Console.WriteLine("Welcome to the Reflecting Activity.");
            Console.WriteLine("");
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            
        }
        else if (_choice == 3){
            Console.WriteLine("Welcome to the Listing Activity.");
            Console.WriteLine("");
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            
        }
        time = SetDuration();
        return time;
    }

    public void ActivityOutro(int choice, int duration){
        
        _choice = choice;
        _duration = duration;

        if (_choice == 1){
            _activity = "Breathing";
        }
        else if (_choice == 2){
            _activity = "Reflecting";
        }
        else if (_choice == 3){
            _activity = "Listing";
        }
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} secomds of the {_activity} Activity.");
        Thread.Sleep(3000);
    }

    public int SetDuration(){
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like you session?");
        string secondsStr = Console.ReadLine();
        int seconds = Convert.ToInt32(secondsStr);
        _duration = seconds;
        return seconds;
    }

    public void Transition(){
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(10);

        Thread.Sleep(500);

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

    public void Animation(int time){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);

        int i = 0;
        

        while (DateTime.Now < futureTime)
        {
            string s = _animationList[i];
            Console.Write($"{s}");
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;

            if (i >= _animationList.Count){
                i = 0;
            }
        }
    }
    public void GetReady(){
       Console.Clear();
       Console.WriteLine("Get ready...");
       Console.WriteLine();
       Thread.Sleep(3000);

       Countdown(9);
    }

    public void Countdown(int count){
        int i = count;

       while (i != -1)
       {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        i --;
       }
    }
}
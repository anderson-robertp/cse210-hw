using System.Formats.Asn1;

public class Listing : Activity{
    // Variables
    private List<string> _listPrompt = new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private List<string> _answers = new List<string>();

    private Random _listRand = new Random();

    //Constructor
    

    //Methods
    public void ListAct(int time){
        _duration = time;
        Console.Clear();
        GetReady();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Thread.Sleep(1000);

        // display random prompt
        int k = _listRand.Next(0, _listPrompt.Count);
        string prompt = _listPrompt[k];
        Console.WriteLine(prompt);
        Console.WriteLine();

        Thread.Sleep(1000);

        //Countdown
        Countdown(9);

        while (DateTime.Now < endTime){
            Console.WriteLine(":");
            string answer = Console.ReadLine();
            _answers.Add(answer);
        }
        Console.WriteLine();
        Console.WriteLine($"Good job. You listed {_answers.Count} things.");
        ActivityOutro(3,time);
    }
    
}
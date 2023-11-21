public class Reflect : Activity{
    // Variable
    private List<string> _openQuery = new List<string>(){
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _ponder = new List<string>(){
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Random _rand = new Random();

    private List<string> _usedPonder = new List<string>();
    
    // Constructor
    public Reflect() : base (){
        _activity = "Reflecting";
        _desc = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    // Methods
    public void ReflectAct(int time){
        _duration = time;
        Console.Clear();
        GetReady();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Thread.Sleep(1000);

        //Random promt
        int i = _rand.Next(0, _openQuery.Count);
        string prompt = _openQuery[i];
        Console.Clear();
        Console.WriteLine(prompt);

        Thread.Sleep(3000);

        while (DateTime.Now < endTime)
        {
            //Random question
            int j = _rand.Next(0, _ponder.Count);
            string ponder = _ponder[j];
            _usedPonder.Add(ponder);
            _ponder.RemoveAt(j);
            Console.WriteLine(ponder);

            // Pause with animation between
            Animation(10);

            // repeat 
        }
        ActivityOutro(2,time);
    }
}
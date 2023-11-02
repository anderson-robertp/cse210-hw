public class List : Activity{
    // Variables

    //Constructor

    //Methods
    public void ListAct(int time){
        _duration = time;
        Console.Clear();
        GetReady();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Thread.Sleep(1000);
        while (DateTime.Now < endTime){
            
        }
    }
    
}
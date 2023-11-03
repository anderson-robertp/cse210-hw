public class Breath : Activity{
    //Variables


    //Constructors
    public Breath() : base(){}

    //public Breath() : base(){}


    //Methods
    public void BreathingAct(int time){
        
        _duration = time;
        Console.Clear();
        GetReady();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Thread.Sleep(1000);

        while (DateTime.Now < endTime)
        {
            //int i = 1;
            //int h = 1;
            //int o = 1;

            Console.WriteLine("");
            Console.WriteLine();
            Console.Write("Breath in...");
            Countdown(4);
            /* while (i != 5)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                i ++;
            }*/

            Console.WriteLine("");
            Console.WriteLine();
            Console.Write("Hold your breathe for...");
            Countdown(8);
            /*while (h != 8)
            {
                Console.Write(h);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                h ++;
            } */
            
            Console.WriteLine("");
            Console.WriteLine();
            Console.Write("Breath out...");
            Countdown(9);
            //while (o != 9)
            //{
                //Console.Write(o);
                //Thread.Sleep(1000);
                //Console.Write("\b \b");
                //o ++;
            //}

        }
        ActivityOutro(1 , time);
    }
}
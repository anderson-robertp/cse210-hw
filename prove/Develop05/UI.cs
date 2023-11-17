public class UI{
    
    // Attributes

    // Constructor
    public UI(){}

    // Methods
    public void DisplayMainMenu(){
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Set Character");
        Console.WriteLine("  6. Record Event");
        Console.WriteLine("  7. Quit");
        
    }
    public void DisplayGoalMenu(){
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        
    }
    public void InitialSetUp(){
        Console.WriteLine("");
        Console.Write("Would you like to 1)load a saved file or 2)start new? ");
        
    }
}
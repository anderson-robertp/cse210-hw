public class API{
    // Attributes

    //Constructor
    public API(){}

    //Methods
    public void Save(List<string> items, string filename){
        using (StreamWriter outputFile = new StreamWriter(filename)){
            foreach (string item in items)
            {
               outputFile.WriteLine($"{item}");
            }
        }
    }
    public string[] Load(string filename){
        string[] items = System.IO.File.ReadAllLines(filename);
        return items;
        
        
    }
}
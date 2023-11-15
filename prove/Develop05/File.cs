public class File{
    // Variables

    // Constructor
    public File(){}

    // Methods

    public void SaveToFile(int points, List<String> goals, string filename){
        using (StreamWriter outputFile = new StreamWriter(filename)){
            outputFile.WriteLine($"{points}");
            foreach(string goal in goals){
                outputFile.WriteLine($"{goal}");
            }
        }
    }

    public string[] LoadFromFile(string filename){
        string[] goals = System.IO.File.ReadAllLines(filename);
        return goals;
    }
}
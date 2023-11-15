public class File{
    // Variables

    // Constructor

    // Methods

    public void SaveToFile(int points, list goals, string filename){
        using (StreamWriter outputFile = new StreamWriter(filename)){
            outputFile.WriteLine($"{points}");
            foreach(goal in goals){
                outputFile.WriteLine($"{goal}");
            }
        }
    }

    public List LoadFromFile(string filename){
        sting[] goals = System.IO.File.ReadAllLines(filename);
    }
}
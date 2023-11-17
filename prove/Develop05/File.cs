public class File{
    // Variables

    // Constructor
    public File(){}

    // Methods

    public void SaveToFile(string outChar, List<String> goals, string filename){
        using (StreamWriter outputFile = new StreamWriter(filename)){
            outputFile.WriteLine($"{outChar}");
            foreach(string goal in goals){
                outputFile.WriteLine($"{goal}");
            }
        }
    }

    public string[] LoadFromFile(string filename){
        string[] goals = System.IO.File.ReadAllLines(filename);
        return goals;
    }
    public List<Goal> ConvertToGoals(string[] goals){
        List<Goal> goalList = new List<Goal>();
        foreach(string line in goals.Skip(1)){
                    string [] parts = line.Split(":");
                    string type = parts[0];
                    string[] goal = parts[1].Split(",");
                    if(type == "simple"){
                        string name = goal[0];
                        string desc = goal[1];
                        int pnts= int.Parse(goal[2]);
                        bool complete = bool.Parse(goal[3]);
                        Simple simp = new Simple(type,name,desc,pnts,complete);
                        goalList.Add(simp);
                    }
                    else if(type == "eternal"){
                        string name = goal[0];
                        string desc = goal[1];
                        int pnts= int.Parse(goal[2]);
                        Eternal eter = new Eternal(type,name,desc,pnts);
                        goalList.Add(eter);
                    }
                    else if(type == "checklist"){
                        string name = goal[0];
                        string desc = goal[1];
                        int pnts= int.Parse(goal[2]);
                        int bonus = int.Parse(goal[3]);
                        int times = int.Parse(goal[4]);
                        int completed = int.Parse(goal[5]);
                        Checklist check = new Checklist(type,name,desc,pnts,bonus,times,completed);
                        goalList.Add(check);
                    }
        }
        return goalList;
    }
}
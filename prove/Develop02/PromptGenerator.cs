using System;
using Microsoft.VisualBasic;

public class PromptGenerator
{
    // Declare variables
    string[] _prompts = System.IO.File.ReadAllLines("prompt.txt");
    public string _prompt;
    public List<string> _todaysPrompts = new List<string>();
     
    
    


    // Constructor
    public PromptGenerator(){}

    // Methods
    public string GeneratePrompt(){
        /*
        Method: loads file containing prompts and choose one randomly

        Variables: none

        Returns: prompt

        */
        var Random = new Random();
        var unique = false;
        while (unique != true) { 
            int index = Random.Next(0,_prompts.Length - 1);
            _prompt = _prompts[index];
            if (_todaysPrompts.Contains(_prompt)){
                break;
            }
            else {
                _todaysPrompts.Add(_prompt);
                unique = true;
            }
        }
        return _prompt;
    }
}   
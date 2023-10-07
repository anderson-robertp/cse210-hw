using System;
using Microsoft.VisualBasic;

public class PromptGenerator
{
    // Declare variables
    string[] _prompts = System.IO.File.ReadAllLines("prompt.txt");
    public string _prompt;
     
    
    


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
        int index = Random.Next(0,_prompts.Length - 1);
        _prompt = _prompts[index];
        return _prompt;

    }
}   
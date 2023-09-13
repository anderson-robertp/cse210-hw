using System;

class Program
{
    static void Main(string[] args)
    {
        /* Ask for grade value and convert to int */
        Console.WriteLine("What is your grade? i.e. 85:");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);

        /* Declare variable */
        string letterGrade;
        string sign = "";

        /* Operations to determine letter value for grade*/
        if (grade >= 90)
            {
                letterGrade = "A";
            }
        else if (grade >= 80)
            {
                letterGrade = "B";
            }
        else if (grade >=70)
            {
                letterGrade = "C";
            }
        else if (grade >= 60)
            {
                letterGrade = "D";
            }
        else
            {
                letterGrade = "F";
            }
        
        /* Operations to determine '+' or '-' sign */
        if (grade < 94 && grade >= 60)
            {
                int remainder = grade % 10;
                if (remainder >=7)
                    {
                        sign = "+";
                    }
                else if (remainder < 3 && remainder != 0)
                    {
                        sign = "-";
                    }
            }
        
        
        /* Print Letter grade results */
        Console.WriteLine($"Your letter grade is: {letterGrade}{sign}");

        /* Determine message based on grade */
        if (grade >= 70)
            {
                Console.WriteLine("Congrats! You passed!");
            }
        else
            {
                Console.WriteLine("Better luck next sememster.");
            }
    }
}
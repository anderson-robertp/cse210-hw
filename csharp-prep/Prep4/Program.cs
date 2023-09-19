using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Generate list
        List<int>numberList = new List<int>();
        int number = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (number != 0);
        {
            Console.WriteLine("Enter a number:");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number !=0)
            {
                numberList.Add(number);
            }
        }
        
        //Calulate sum of list
        // int prevNumber = 0; - Testing
        int totalN = 0;
        //int iteration = 1; - Testing
        foreach (int n in numberList)
        {
            totalN = totalN + n;
            //Console.WriteLine($"{iteration}:{totalN} = {prevNumber} + {n}"); - Testing
            //prevNumber = n; - Testing
            // iteration++; - Testing
        }
        Console.WriteLine($"The sum of the list is {totalN}.");

        //Compute Average
        float avg = ((float)totalN) / numberList.Count;
        Console.WriteLine($"The average is {avg}.");

        // Find Max
        int max = 0;
        foreach (int n in numberList)
        {
            if (max < n)
            {
                max = n;
            }
        }
        Console.WriteLine($"The greatest number is {max}");

        // Find smallest positive value
        int spv = 100;
        foreach (int n in numberList)
        {
            if (n > 0 && spv > n)
            {
                spv = n;
            }
        }
        Console.WriteLine($"Smallest Positive value is {spv}");

        // Sort list from smallest to largest
        numberList.Sort();
        for (int j =0; j < numberList.Count; j++)
        {
            int line = numberList[j];
            Console.WriteLine(line);
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        // Call random
        Random randomGenerator = new Random();

        // variables
        str response == "yes"
        int i = 0

        //doWhile for gameplay
        do
        {
            // Gen magic number
            int magicNumber = randomGenerator.Next)1,100);

            while (guess != magicNumber)
            {
                Console.WriteLine("What is your guess? ");
                str guessStr = Console.ReadLine();
                int guess = intParse.(guessStr);

                if (guess = magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                }
                if (guess > magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                i++
            }

            Console.WriteLine($"You guessed {i} times.");
            Console.WriteLine();
            Console.WriteLine("Would you like to play again? yes/no");
            response = Console.ReadLine();

        } while (response == "yes");
    }
}
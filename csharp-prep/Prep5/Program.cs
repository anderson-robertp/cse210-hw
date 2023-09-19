using System;

class Program
{
    static void Main(string[] args)
    {
        // Display Welcome mesage
        DisplayWelcome();

        // Prompt for user name
        string name = PromptUserName();

        // Prompt the user for a number
        int number = PromtUserNumber();

        // Square user number
        int squareNumber = SquareNumber(number);

        //Display results
        DisplayResult(name,squareNumber);

    }
    static void DisplayWelcome()
    /*
    Function: To display the welcome message.

    Parameters: None

    Returns: nothing

    */
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    /*
    Function: Prompt user for a string value user name

    Parameters: None

    Returns: userName

    */
    {
        Console.WriteLine("Please enter your name:");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromtUserNumber()
    /*
    Function: Prompt the user for a number to be squared later

    Parameters: None

    Returns: userNumber

    */
    {
        Console.WriteLine("Please enter your favorite number:");
        string userNumberStr = Console.ReadLine();
        int userNumber = int.Parse(userNumberStr);
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    /*
    Function: Squares the number provided by the user

    Parameters: userNumber provided from function PromptUserNumnber

    Returns: squaredNumber

    */
    {
        int squaredNumber = userNumber * userNumber;
        return squaredNumber;
    }
    static void DisplayResult(string userName, int squareNumber)
    /*
    Function: Displays user prompted information.

    Parameters: userName and squareNumber

    Returns: nothing

    */
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}.");
    }
}
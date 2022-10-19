//Namespace declarations:
using System;

class MyProgram
{
    static void Main()
    {
        Console.Write("Please Enter a number: ");
        string userInput = Console.ReadLine();
        CalcInputWithParams(userInput);
        Console.Write("Please Enter another number: ");
        string userInput2 = Console.ReadLine();
        CalcInputWithParams(userInput2);
    }

    static void Calculate()
    {
        int valOne = 2;
        int valTwo = 3;
        int result;

        result = valOne + valTwo;
        Console.Write(result + "\n");
    }

    static void CalculateUserInput()
    {
        Console.Write("Please enter a number: ");
        int five = 5;
        int userInput = Convert.ToInt32(Console.ReadLine());
        int result = five + userInput;
        Console.Write("That number plus 5 is " + result + "\n");
    }

    static void CalcInputWithParams(string userParam)
    {
        int five = 5;
        int userInput = Convert.ToInt32(userParam);
        int result = five + userInput;
        Console.Write("That number plus 5 is " + result + "\n");
    }
}

class MyProgram
{
    static void Main()
    {
        System.Console.Write("Please Enter a number: ");
        string userInput = System.Console.ReadLine();
        CalcInputWithParams(userInput);
        System.Console.Write("Please Enter another number: ");
        string userInput2 = System.Console.ReadLine();
        CalcInputWithParams(userInput2);
    }

    static void Calculate()
    {
        int valOne = 2;
        int valTwo = 3;
        int result;

        result = valOne + valTwo;
        System.Console.Write(result + "\n");
    }

    static void CalculateUserInput()
    {
        System.Console.Write("Please enter a number: ");
        int five = 5;
        int userInput = System.Convert.ToInt32(System.Console.ReadLine());
        int result = five + userInput;
        System.Console.Write("That number plus 5 is " + result + "\n");
    }

    static void CalcInputWithParams(string userParam)
    {
        int five = 5;
        int userInput = System.Convert.ToInt32(userParam);
        int result = five + userInput;
        System.Console.Write("That number plus 5 is " + result + "\n");
    }
}

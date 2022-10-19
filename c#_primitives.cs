class MyProgram
{
    static void Main()
    {
        //Integers
        int numOne = 1;
        int numTwo = 1;
        int result;
        result = numOne + numTwo;
        System.Console.Write(result + "\n");

        //Strings
        string phraseOne = "Hey, I am learning!";

        //User input
        string userInput = System.Console.ReadLine();
        System.Console.Write(phraseOne + "\n" + userInput + "\n");

        //Floats
        float floatOne = 1.5f;
        float floatTwo = 2.5f;
        float resultFloat;
        resultFloat = floatOne + floatTwo;
        System.Console.Write(resultFloat + "\n");

        //Booleans
        bool trueVal = true;
        bool falseVal = false;
        System.Console.Write(trueVal + "\n" + falseVal + "\n");

    }
}

// mcs + filename --> compile
// mono + exe file --> run
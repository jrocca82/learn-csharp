using System;

namespace Practice
{
    class MyProgram
    {
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                CalcInput();
            }
        }

        static void CalcInput()
        {
            Console
                .Write("Please enter a number between 1 and 10, inclusive: ");
            string userInput = Console.ReadLine();
            int userNumber;
            bool isNumerical = int.TryParse(userInput, out userNumber);

            //Check if greater than or less than 5
            if (isNumerical)
            {
                if (userNumber >= 1 && userNumber <= 5)
                {
                    Console.Write("You chose a number between 1 and 5 \n");
                }
                else if (userNumber <= 0)
                {
                    Console
                        .Write("Tricky tricky, you chose a negative number!\n");
                }
                else if (userNumber > 10)
                {
                    Console
                        .Write("You have trouble following directions... that number is more than 10\n");
                }
                else
                {
                    Console
                        .Write("You chose a number that is between 5 and 10\n");
                }
            } else {
                Console.Write("That is not a number, silly!\n");
            }
        }
    }
}

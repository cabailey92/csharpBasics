using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a variable
            int number = 0; //If condistion is true; loop!

            // Keyword Condition
            while (number <= 100)
            {
                //Loop
                // Print the number and add 5
                Console.WriteLine(number);
                number = number + 5;
            }
        }
    }
}

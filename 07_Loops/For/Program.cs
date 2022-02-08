using System;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create initial target
            int number = 100;

            // for (initializer; condition; iterator) {body}

            //1     //2     //3         //4
            for (int i = 1; i <= number; i++)
            {
                //5
                Console.WriteLine(i);
            }

            //1 - for Keyword
            //2 - Declaration and initialization of iterator
            //3 - Boolean expression for the loop
            //4 - Increment the iterator at the END of the loop
            //5 - Body, runs per iteration if the condition is true

            int numberTwo = 200;
            for (int i = 1; i <= numberTwo; i++){
                numberTwo = numberTwo - i;
                Console.WriteLine(numberTwo);
                Console.WriteLine($"i is {i} ");

            }
        }
    }
}

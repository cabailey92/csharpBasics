using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int additionResult = 5 + 2;
            Console.WriteLine("5 + 2 = " + additionResult);

            int subtractionResult = 5 - 2;
            Console.WriteLine("5 - 2 = " + subtractionResult);

            int multiplicationResult = 5 * 2;
            Console.WriteLine("5 * 2 = " + multiplicationResult);

            double divisionResult = 5d / 2d;
            Console.WriteLine("5 / 2 = " + divisionResult);

            Console.WriteLine(10 % 2);
            Console.WriteLine(10 % 9);
            Console.WriteLine(16 % 3);
            Console.WriteLine(19 % 5);
            
        }
    }
}

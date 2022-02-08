using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
        int iterator = 0;

        do
        {
            Console.WriteLine("Hello!");
            iterator++;
        } 
        while (iterator < 5);


        do{
            Console.WriteLine("My condition is false!");
        }
        while(false);

        while(false){
            Console.WriteLine("My condition is false!");
        }
        }
    }
}

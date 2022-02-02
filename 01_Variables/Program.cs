using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("GIVE ME YOUR NAME.");
        string firstName = Console.ReadLine();
        Console.WriteLine(firstName);

        Console.WriteLine("What is your favoite color");
        string color = Console.ReadLine();

        Console.WriteLine("You said your color is " + color);
        }
    }
}

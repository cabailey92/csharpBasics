using System;

namespace ForeachLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string instructorName = "Jacob";
            string[] instructors = new string[] {"Adam","Kate",instructorName};
            //List(string)

            // foreach(declasredIterator in enumerableCollection){body}

            foreach(string name in instructors){
                Console.WriteLine($"Hello {name}");
            }

            foreach(char letter in instructorName){
                if(letter == 'c'){
                    Console.WriteLine('k');
                }
                else
                Console.WriteLine(letter);
            }
        }
    }
}

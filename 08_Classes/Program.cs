using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            using Classes;

            Donut doug = new Donut("Jelly Filled",true,false);
            doug.SetDonutType("Glazed");
            doug.Filling = "Strawberry jam";
            Console.WriteLine(doug.GetDonutType());
            Console.WriteLine(doug.Filling);

            Donut derrick = new Donut("Chocolate Eclair",false,true,3.99);
            Console.WriteLine(derrick.Price);

            Greeter greet= new Greeter();
            Console.WriteLine(greet.SayHello("Chris"));
            Console.WriteLine(greet.SayHello());

            greet.PrintHello("Alex");
            greet.PrintHello("Tony");

            greet.PrintRandomGreeting
            
            
            namespace Classes
            {
            
                class Donut 
                {
                    
                    private string donutType;
                    //Constructors
                    //public Donut(){} <= Implicit constructor
                    // v Defined constructor, implicit constructor removed

                    public Donut(string type, bool sprinkles, bool icing)
                    {
                        donutType = type;
                        IsSprinkled = sprinkles;
                        HasIcing = icing;
                    }
                    public Donut(string type, bool sprinkles, bool icing, double price)
                    {
                        donutType = type;
                        IsSprinkled = sprinkles;
                        HasIcing = icing;
                        Price = price;
                    }


                    // Method V
                    //1     2       3

                    public string GetDonutType()
                    {
                        //4
                        return donutType;
                    }
                    
                    // 1 Access modifier , privte (only accessible within the class), public (available everywhere) etc
                    // 2 Return type, when I run the method, what i get back
                    // 3 Method signature, Name(Parameters)
                    // 4 The body and the return

                    public void SetDonutType(string type)
                    {
                        donutType = type;
                    }

                    // Properties
                    public string Filling {get; set; }
                    public bool IsSprinkled {get; set; }

                    public bool HasIcing {get; set; }
                    public double Price {get; set; }
                }
                class Greeter
                {
                    Random _random = new Random();
                    public string SayHello(){
                        return "Hello!";
                    }
                    public string SayHello(string name)
                    {
                        return $"Hello {name}!";
                    }

                    public void PrintHello(string name)
                    {
                        Console.WriteLine($"Greetings {name}!");
                    }

                    public void PrintRandomGreeting();
                    {
                        string[] availableGreeting = new string[]{"Hello","Wasup","Sup","Yo","Top of the morning"};
                        int randomNumber = random.Next(0,availableGreeting.length);
                        string randomGreeting = availableGreeting.ElementAt(randomNumber);
                        Console.WriteLine(randomGreeting);
                    }
                }











            }
        }
    }
}

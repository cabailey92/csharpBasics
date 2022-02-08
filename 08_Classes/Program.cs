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

            greet.PrintRandomGreeting();

            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Age(new DateTime(1991,05,04)));
            
            
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
                class Calculator
                {
                    public int Add(int numOne, int numTwo)
                    {
                        return numOne + numTwo;
                    }
                    public double Add(double numOne, double numTwo)
                    {
                        return numOne + numTwo;
                    }
                    public int Subtract(int numOne, int numTwo)
                    {
                        return numOne - numTwo;
                    }
                    public int Multiply(int numOne, int numTwo)
                    {
                        return numOne * numTwo;
                    }
                    public int Divide(int numOne, int numTwo)
                    {
                        return numOne / numTwo;
                    }
                    public int Remainder(int numOne, int numTwo)
                    {
                        return numOne % numTwo;
                    }
                    public int Age(DateTime birthdate)
                    {
                        TimeSpan ageSpan = DateTime.Now - birthdate;
                        double totalAgeInYears = ageSpan.Totaldays / 365.25;
                        int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
                        return years;
                    }
                }
                class Person
                {
                    public string FirstName { get; set; }
                    public string LastName { get; set; }
                    //Read only Property
                    public string FullName
                    { 
                        get
                        {
                            return FirstName + " " + LastName;
                        }
                    }
                    
                    public DateTime DateOfBirth {get; set;}
                    
                    public int Age
                    {
                        get
                        {
                            Calculator calc = new Calculator();
                            return calc.Age(DateOfBirth);
                        }
                    }











            }
        }
    }
}

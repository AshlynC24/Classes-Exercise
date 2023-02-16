using System;
using System.Reflection;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
              public class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }


        }
        public void HowOldCarIs()
        {
            Console.WriteLine($"Year of {myCar.Make} {myCar.Model} is {myCar.Year}");
        }
        Car myCar = new Car()
        {
            Make = "Ford",
            Model = "F-150",
            Year = 2015,
        };
    }
   
    }
}

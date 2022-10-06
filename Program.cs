using System;

namespace PropertiesTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Student Std1 = new Student("Shirish", 30);
            Console.WriteLine($"Name : {Std1.Name} | Result : {Std1.Result} with {Std1.Marks} Marks");

            Movie avengers = new Movie("Avenders", "PG34");
            Console.WriteLine($"{avengers.title} has {avengers.Rating}");
        }
    }
}

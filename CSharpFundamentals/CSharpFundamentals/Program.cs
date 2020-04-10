using System;
using System.Collections.Generic;


namespace CSharpFundamentals
{
    //Module 4 - Working with Classes an Objects
    //When your software is becoming too complex when you have a method that has to much code inside of it, that's when you should start thinking about "How can I use a new class to provide some encapsulation for the complexity I'm looking at"
    internal class Program
    {

        // static members are not associated with an object instance. Static members are associated with the type that they are defined inside of
        private static void Main(string[] args)
        {
            // example of static use
            // Program.Main() <-- this is possible because the Main() method is associated with the type not with an object

            Book book = new Book("David's Grade Book");
            book.AddGrade(42.4);        // An object of type book. Because I have the class 'Book' I can create a books as long as I want and that book will have it's own behavior
            book.AddGrade(90.5);

            var grades = new List<double>() { 12.3, 10.7, 6.11, 4.1, 45.3 };
            grades.Add(56.1);

            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var grade in grades)
            {
                if (grade > highGrade)
                {
                    highGrade = grade;
                }

                lowGrade = Math.Min(grade, lowGrade);

                result += grade;
            }

            result /= grades.Count;

            Console.WriteLine($"The average grade is: {book.ComputeAverageGrade(grades):N1}");
            Console.WriteLine($"The highest grade is: {highGrade}");
            Console.WriteLine($"The lowest grade is: {lowGrade}");

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[1]}!");
            }
            else
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
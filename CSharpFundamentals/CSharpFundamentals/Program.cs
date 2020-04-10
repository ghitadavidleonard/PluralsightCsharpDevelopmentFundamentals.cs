using System;
using System.Collections.Generic;


namespace CSharpFundamentals
{
    //Module 4 - Working with Classes an Objects
    //When your software is becoming too complex when you have a method that has to much code inside of it, that's when you should start thinking about "How can I use a new class to provide some encapsulation for the complexity I'm looking at"
    internal class Program
    {
        private static void Main(string[] args)
        {
            Book book = new Book();
            book.AddGrade(42.4);


            var grades = new List<double>() { 12.3, 10.7, 6.11, 4.1, 45.3 };
            grades.Add(56.1);

            var result = 0.0;

            foreach (var grade in grades)
            {
                result += grade;
            }

            result /= grades.Count;
            Console.WriteLine($"The average grade is {book.ComputeAverageGrade(grades):N1}");

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
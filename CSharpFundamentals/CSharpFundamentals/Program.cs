using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var grades = new List<double>() { 12.3, 10.7, 6.11, 4.1, 45.3 };
            grades.Add(56.1);

            var result = 0.0;

            foreach (var grade in grades)
            {
                result += grade;
            }

            result /= grades.Count;
            Console.WriteLine($"The average grade is {result:N1}");

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
using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    // Think of a class as a blueprint. It describes how I will build objects
    public class Book
    {
        // fields or properties (With fields you can't use implicit typing)
        private List<double> grades;
        private string name;

        // constructors - the ideea of a constructor is that it constructs objects with some default values 
        public Book(string name)
        {
            grades = new List<double>();
            // this is a reference to the object that we operate on
            this.name = name;
        }


        // methods
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
            Console.WriteLine($"The average grade is: {GetAverageGrade()}");
            Console.WriteLine($"The lowest grade is: {GetLowestGrade()}");
            Console.WriteLine($"The highest grade is: {GetHighestGrade()}");
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.High = GetHighestGrade();
            result.Low = GetLowestGrade();
            result.Average = GetAverageGrade();

            return result;
        }

        private double GetLowestGrade()
        { 
            var lowGrade = double.MaxValue;

            foreach (var grade in grades)
            {
                lowGrade = Math.Min(grade, lowGrade);
            }

            return lowGrade;
        }

        private double GetHighestGrade()
        {
            var highGrade = double.MinValue;

            foreach (var grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
            }

            return highGrade;
        }

        private double GetAverageGrade()
        {
            var result = 0.0;

            foreach (var grade in grades)
            {
                result += grade;
            }

            return result / grades.Count;
        }
    }
}

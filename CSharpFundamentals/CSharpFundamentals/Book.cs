using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    // Think of a class as a blueprint. It describes how I will build objects
    public class Book
    {
        private List<double> grades;
        public string Name;

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        // methods
        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid value!");
            }
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
            int index = 0;
            // the do while loop will execute at least once
            if (grades.Count > 0)
            {
                do
                {
                    lowGrade = Math.Min(grades[index], lowGrade);
                    index++;
                } while (index < grades.Count);
            }
            return lowGrade;
        }

        private double GetHighestGrade()
        {
            var highGrade = double.MinValue;
            var index = 0;

            // use continue to go to the next interation
            while (index < grades.Count)
            {
                //if (grades[index] == 42.1)
                //{
                //    continue
                //}
                highGrade = Math.Max(grades[index], highGrade);
                index++;
            }

            return highGrade;
        }

        private double GetAverageGrade()
        {
            var result = 0.0;
            // breaking a loop
            for (var i = 0; i < grades.Count; i++)
            {
                //if (grades[i] == 42.1)
                //{
                //    break;
                //}
                result += grades[i];
            }

            return result / grades.Count;
        }
    }
}
using System;
using System.Collections.Generic;

namespace CSharpFundamentals
{
    // Think of a class as a blueprint. It describes how I will build objects
    public class Book
    {
        private List<double> grades;
        private string name;
        
        public string Name 
        { 
            get 
            {
                return name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException($"Invalud {nameof(name)}");
                }
            }
        }

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;
                case 'B':
                    AddGrade(80);
                    break;
                case 'C':
                    AddGrade(70);
                    break;
                default:
                    AddGrade(0);
                    break;
            }
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
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public void ShowStatistics()
        {
            Console.WriteLine($"The average grade is: {GetAverageGrade()}");
            Console.WriteLine($"The lowest grade is: {GetLowestGrade()}");
            Console.WriteLine($"The highest grade is: {GetHighestGrade()}");
            Console.WriteLine($"The letter grade is: {GetLetterGrade()}");
        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.High = GetHighestGrade();
            result.Low = GetLowestGrade();
            result.Average = GetAverageGrade();
            result.Letter = GetLetterGrade();

            return result;
        }

        private double GetLowestGrade()
        {
            var lowGrade = double.MaxValue;
            int index = 0;

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

            while (index < grades.Count)
            {
                highGrade = Math.Max(grades[index], highGrade);
                index++;
            }

            return highGrade;
        }

        private double GetAverageGrade()
        {
            var result = 0.0;
            for (var i = 0; i < grades.Count; i++)
            {
                result += grades[i];
            }

            return result / grades.Count;
        }


        private char GetLetterGrade()
        {
            switch(GetAverageGrade())
            {
                case var d when d >= 90:
                    return 'A';

                case var d when d >= 80:
                    return 'B';

                case var d when d >= 70:
                    return 'C';

                case var d when d >= 60:
                    return 'D';

                default:
                    return 'F';
            }
        }
    }
}
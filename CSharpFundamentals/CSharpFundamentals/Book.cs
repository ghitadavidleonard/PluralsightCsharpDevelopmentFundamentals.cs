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
        public double ComputeAverageGrade(List<double> grades)
        {
            var result = grades[0];
            foreach (var grade in grades)
            {
                result += grade;
            }

            return result / grades.Count;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }
    }
}

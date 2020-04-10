using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public class Book
    {
        public Book()
        {
           
        }

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
     
        }
    }
}

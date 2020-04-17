using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public interface IBook
    {
        public string Name { get; }
        void AddGrade(double grade);
        Statistics GetStatistics();
        event GradeAddedDelegate GradeAdded;
    }
}

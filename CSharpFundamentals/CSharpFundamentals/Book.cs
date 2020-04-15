using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public abstract class Book : NamedObject, IBook
    {
        public virtual event GradeAddedDelegate GradeAdded;

        public abstract void AddGrade(double grade);

        public virtual Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }

        protected Book(string name) : base(name)
        {
        }
    }
}

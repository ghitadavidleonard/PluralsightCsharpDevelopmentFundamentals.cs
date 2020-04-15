using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFundamentals
{
    public abstract class Book : NamedObject
    {
        public abstract void AddGrade(double grade);
        protected Book(string name) : base(name)
        {
        }
    }
}

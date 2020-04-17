using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharpFundamentals
{
    class DiskBook : Book, IBook
    {
        public override event GradeAddedDelegate GradeAdded;
        public DiskBook(string name) : base(name)
        {
        }

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText($"{Name}.txt"))
            {
                writer.WriteLine(grade);
                GradeAdded?.Invoke(this, new EventArgs());
            }
        }

        public override Statistics GetStatistics()
        {

            var result = new Statistics();
            
            using (var reader = File.OpenText($"{Name}.txt"))
            {
                var line = reader.ReadLine();

                while(line != null)
                {
                    var number = double.Parse(line);
                    result.Add(number);
                    line = reader.ReadLine();
                }
            }

            return result;
        }
    }
}

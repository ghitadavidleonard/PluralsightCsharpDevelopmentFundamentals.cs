using System;
using System.Collections.Generic;


namespace CSharpFundamentals
{
    //Module 4 - Working with Classes an Objects
    //When your software is becoming too complex when you have a method that has to much code inside of it, that's when you should start thinking about "How can I use a new class to provide some encapsulation for the complexity I'm looking at"
    internal class Program
    {

        // static members are not associated with an object instance. Static members are associated with the type that they are defined inside of
        private static void Main(string[] args)
        {
            // example of static use
            // Program.Main() <-- this is possible because the Main() method is associated with the type not with an object

            Book book = new Book("David's Grade Book");
            book.AddGrade(89.1);        // An object of type book. Because I have the class 'Book' I can create a books as long as I want and that book will have it's own behavior
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            book.ShowStatistics();
        }
    }
}
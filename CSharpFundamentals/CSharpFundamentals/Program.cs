using System;

namespace CSharpFundamentals
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Book book = new Book("David's Grade Book");

            book.GradeAdded += OnGradeAdded;

            EnterGrade(book);

            book.ShowStatistics();

            Console.WriteLine(Book.CATEGORY);
            Console.WriteLine($"For the book named {book.Name}");
        }

        private static void EnterGrade(Book book)
        {
            string input = "";

            while (!input.Contains("q"))
            {
                Console.WriteLine("Enter a grade...");
                var grade = Console.ReadLine();
                input = grade;
                if (Double.TryParse(grade, out double smth))
                {
                    try
                    {
                        book.AddGrade(Double.Parse(grade));
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("**");
                    }
                }
            }
        }

        static void OnGradeAdded(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("A grade was added!");
        }

    }
}
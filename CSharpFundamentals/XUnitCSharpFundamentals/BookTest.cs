using CSharpFundamentals;
using System;
using Xunit;

namespace XUnitCSharpFundamentals
{
    public class BookTest
    {
        // The test code should be executable statements
        // We use "Fact" attribute for the actual unit tests methods
        [Fact]
        public void BookCalculatesAnAverangeGrade()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }

        [Fact]
        public void AddGradeBetween0and100()
        {
            // arrage
            var book = new Book("Existance");

            // act
            book.AddGrade(105);
            book.AddGrade(-43);

            // assert
            Assert.NotEqual(105, book.GetStatistics().High, 1);
            Assert.NotEqual(-43, book.GetStatistics().Low, 1);
        }
    }
}

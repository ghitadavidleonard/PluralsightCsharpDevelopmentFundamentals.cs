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
            var book = new InMemoryBook("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act
            var result = book.GetStatistics();

            // assert
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
            Assert.Equal('B', result.Letter);
        }

        [Fact]
        public void AddGradeBetween0and100()
        {
            // arrage
            var book = new InMemoryBook("Existance");
            Type exceptionType = typeof(ArgumentException);

            // assert
            Assert.Throws(exceptionType, () => book.AddGrade(105));
            Assert.Throws<ArgumentException>(() => book.AddGrade(-43));
        }
    }
}

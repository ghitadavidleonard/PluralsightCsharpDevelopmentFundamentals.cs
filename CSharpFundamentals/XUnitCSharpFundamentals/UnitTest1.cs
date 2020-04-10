using System;
using Xunit;

namespace XUnitCSharpFundamentals
{
    public class UnitTest1
    {
        // The test code should be executable statements
        // We use "Fact" attribute for the actual unit tests methods
        [Fact]
        public void Test1()
        {
            // arrange
            var x = 5;
            var y = 2;
            var expected = 7;

            // act
            var actual = x + y;

            // assert
            Assert.Equal(expected, actual);
        }
    }
}

using Acme.Common;
using Xunit;

namespace Acme.CommonTest
{
    public class StringHandlerTest
    {
        [Fact]
        public void InsertSpaceIsValid()
        {
            //-- Arrange
            var source = "SonicScrewdriver";
            var expected = "Sonic Screwdriver";

            //-- Act
            var actual = StringHandler.InsertSpaces(source);

            //-- Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertSpacesTestWithExistingSpace()
        {
            //-- Arrange
            var source = "Sonic Screwdriver";
            var expected = "Sonic Screwdriver";

            //-- Act
            var actual = StringHandler.InsertSpaces(source);

            //-- Assert
            Assert.Equal(expected, actual);
        }
    }
}
using ACM.BL;
using System;
using Xunit;

namespace ACM.BLTest
{
    public class OrderRepositoryTest
    {
        [Fact]
        public void RetrieveValid()
        {
            //-- Arrange
            var orderRepository = new OrderRepository();

            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0))
            };

            //-- Act
            var actual = orderRepository.Retrieve(10);

            //-- Assert
            Assert.Equal(expected.OrderDate, actual.OrderDate);
            Assert.Equal(expected.OrderId, actual.OrderId);
        }
    }
}
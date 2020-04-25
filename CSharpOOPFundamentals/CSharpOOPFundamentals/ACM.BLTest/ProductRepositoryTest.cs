using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Sdk;

namespace ACM.BLTest
{
    public class ProductRepositoryTest
    {
        [Fact]
        public void RetrieveTest()
        {
            //-- Arrange
            var productRepository = new ProductRepository();

            var expected = new Product(2)
            {
                ProductName = "Sunflowers",
                Description = "Assorted Size set of 4 Bright Yellow Mini Sunflowers",
                CurrentPrice = 15.96M
            };
            //-- Act
            var actual = productRepository.Retrieve(2);

            //-- Assert
            Assert.Equal(expected.ProductId, actual.ProductId);
            Assert.Equal(expected.CurrentPrice, actual.CurrentPrice);
            Assert.Equal(expected.ProductName, actual.ProductName);
            Assert.Equal(expected.Description, actual.Description);
        }

        [Fact]
        public void SaveTestValid()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                Description = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //-- Act
            var actual = productRepository.Save(updatedProduct);

            //-- Assert
            Assert.True(actual);
        }

        [Fact]
        public void SaveTestMissingPrice()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                Description = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //-- Act
            var actual = productRepository.Save(updatedProduct);

            //-- Assert
            Assert.False(actual);
        }
    }
}

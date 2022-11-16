using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.TEST
{
    internal class ProductRepositoryTest
    {
        [Test]
        public void RetrieveValid()
        {
            // arrange 
            ProductRepository productRepository = new ProductRepository();

            var expected = new Product()
            {
                ProductId = 2,
                ProductName = "Haribo",
                ProductDescription = "Sweets, no good for teeth",
                CurrentPrice = 24.99m

            };

            // act
            var actual = productRepository.Retrieve(2);

            // assert
            Assert.That(expected.ProductId, Is.EqualTo(actual.ProductId));
            Assert.That(expected.ProductName, Is.EqualTo(actual.ProductName));
            Assert.That(expected.ProductDescription, Is.EqualTo(actual.ProductDescription));
            Assert.That(expected.CurrentPrice, Is.EqualTo(actual.CurrentPrice));

        }

        [Test]
        public void SaveTestValid()
        {
            // arrange
            var productRepository = new ProductRepository();

            var updatedProduct = new Product(2)
            {
                ProductId = 2,
                ProductName = "Haribo",
                ProductDescription = "Sweets, no good for teeth",
                CurrentPrice = 24.99m,
                HasChanges = true
            };

            // act
            var actual = productRepository.Save(updatedProduct);

            // assert
            Assert.That(true, Is.EqualTo(actual));
        }

        [Test]
        public void SaveTestMissingPrice()
        {
            // arrange
            // arrange
            var productRepository = new ProductRepository();

            var updatedProduct = new Product(2)
            {
                ProductId = 2,
                ProductName = "Haribo",
                ProductDescription = "Sweets, no good for teeth",                
                CurrentPrice = null,
                HasChanges = true
            };

            // act
            var actual = productRepository.Save(updatedProduct);

            // assert
            Assert.That(false, Is.EqualTo(actual));
        }
    }
}

using System.Net;

namespace ACM.BL.TEST
{
    public class CustomerRepositoryTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RetrieveValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();

            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

            // Act
            var actual = customerRepository.Retrieve(1);

            // Assert
            Assert.That(expected.FirstName, Is.EqualTo(actual.FirstName));
            Assert.That(expected.LastName, Is.EqualTo(actual.LastName));
            Assert.That(expected.EmailAddress, Is.EqualTo(actual.EmailAddress));
        }

        [Test]
        public void RetrieveExistingWithAddress()
        {
            // arrange 
            var customerRespository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "Bag End",
                        StreetLine2 = "Bagshot row",
                        City = "Hobbiton",
                        State = "Shire",
                        PostalCode = "144",
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green Dragon",
                        City = "Bywater",
                        State = "Shire",
                        PostalCode = "146",
                    }
                }
            };

            // act
            var actual = customerRespository.Retrieve(1);

            // assert
            Assert.That(actual.CustomerId, Is.EqualTo(expected.CustomerId));
            Assert.That(actual.EmailAddress, Is.EqualTo(expected.EmailAddress));
            Assert.That(actual.FirstName, Is.EqualTo(expected.FirstName));
            Assert.That(actual.LastName, Is.EqualTo(expected.LastName));

            for (int i = 0; i < 1; i++)
            {
                Assert.That(actual.AddressList[i].AddressType, Is.EqualTo(expected.AddressList[i].AddressType));
                Assert.That(actual.AddressList[i].StreetLine1, Is.EqualTo(expected.AddressList[i].StreetLine1));
                Assert.That(actual.AddressList[i].City, Is.EqualTo(expected.AddressList[i].City));
                Assert.That(actual.AddressList[i].State, Is.EqualTo(expected.AddressList[i].State));
                Assert.That(actual.AddressList[i].PostalCode, Is.EqualTo(expected.AddressList[i].PostalCode));
            }
        }

    }
}

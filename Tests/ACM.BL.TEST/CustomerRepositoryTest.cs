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

    }
}

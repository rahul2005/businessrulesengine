using Moq;
using NUnit.Framework;
using Order.Business.RuleEngine;

namespace Order.Business.RuleEngine.UnitTests
{
    [TestFixture]
    public class PaymentTests
    {
        private MockRepository mockRepository;



        [SetUp]
        public void SetUp()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        private Payment CreatePayment()
        {
            return new Payment();
        }

        [Test]
        public void TestMethod1()
        {
            // Arrange
            var payment = this.CreatePayment();

            // Act


            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }
    }
}

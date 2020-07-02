using Moq;
using NSubstitute;
using NUnit.Framework;
using Order.Business.RuleEngine;
using System;

namespace Order.Business.RuleEngine.UnitTests
{
    [TestFixture]
    public class OperatorTests
    {
        private MockRepository mockRepository;



        [SetUp]
        public void SetUp()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        //private Operator CreateOperator()
        //{
        //    return Substitute.For<Operator>();
        //}

        [Test]
        public void Apply_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
           
            //var operator = this.CreateOperator();
            //Payment payment = null;
            //string op = null;
            //string prop = null;
	
	// Act
	    Operator.Apply(
        new Payment { PaymentId= 23, Purpose= "Book", NextAction= "String"},
        string.Empty,
        string.Empty);

            // Assert
            Assert.Fail();
            this.mockRepository.VerifyAll();
        }
    }
}

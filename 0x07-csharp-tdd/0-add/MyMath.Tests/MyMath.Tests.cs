using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Add_PositiveIntegeres_ReturnPositiveInteger()
        {
            var result = Operations.Add(2, 1);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Add_NegativeIntegeres_ReturnNegativeIngeter()
        {
            var result = Operations.Add(-3, -5);
            Assert.AreEqual(-8, result);
        }

        [Test]
        public void Add_NegativeInteger_ReturnPositiveNumber()
        {
            var result = Operations.Add(-3, 7);
            Assert.AreEqual(4, result);
        }

        [Test]
        public void Add_NegativeInteger_ReturnNegativeNumber()
        {
            var result = Operations.Add(-3, 1);
            Assert.AreEqual(-2, result);
        }

        [Test]
        public void Add_TwoZero_ReturnZero()
        {
            var result = Operations.Add(0, 0);
            Assert.AreEqual(0, result);
        }
    }
}
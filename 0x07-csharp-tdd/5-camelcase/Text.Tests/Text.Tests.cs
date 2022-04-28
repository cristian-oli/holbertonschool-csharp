using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CamelCase_Words_ReturnHowManyWords()
        {
            int result = Str.CamelCase("pythonIsNotCamelCase");
            Assert.AreEqual(result, 5);
        }

        [Test]
        public void CamelCase_EmptyString_ReturnZero()
        {
            int result = Str.CamelCase("");
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void CamelCase_OneWord_ReturnOne()
        {
            int result = Str.CamelCase("hello");
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void CamelCase_TwoWords_ReturnTwo()
        {
            int result = Str.CamelCase("helloWorld");
            Assert.AreEqual(result, 2);
        }
    }
}
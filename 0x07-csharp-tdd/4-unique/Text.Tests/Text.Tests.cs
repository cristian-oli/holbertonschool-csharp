using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void UniqueChar_CommonString_ReturnIndex()
        {
            int result = Str.UniqueChar("test");
            Assert.AreEqual(result, 1);
        }

        [Test]
        public void UniqueChar_CommonString_ReturnMinusOne()
        {
            int result = Str.UniqueChar("anna");
            Assert.AreEqual(result, -1);
        }

        [Test]
        public void UniqueChar_Char_ReturnIndex()
        {
            int result = Str.UniqueChar("a");
            Assert.AreEqual(result, 0);
        }

        [Test]
        public void UniqueChar_EmptyString_ReturnMinusOne()
        {
            int result = Str.UniqueChar("");
            Assert.AreEqual(result, -1);
        }
    }
}
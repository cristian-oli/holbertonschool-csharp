using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void IsPalindrome_WordPalindrome_ReturnTrue()
        {
            bool result = Str.IsPalindrome("radar");
            Assert.AreEqual(true, result);
            result = Str.IsPalindrome("Racecar");
            Assert.AreEqual(true, result);
            result = Str.IsPalindrome("level");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome_SentencePalindrome1_ReturnTrue()
        {
            bool result = Str.IsPalindrome("anita lava la tina");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome_SentencePalindrome2_ReturnTrue()
        {
            bool result = Str.IsPalindrome("Anita lava La tina");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome_SentencePalindrome3_ReturnTrue()
        {
            bool result = Str.IsPalindrome("#!Anita lava La tina   ! #");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome_SentencePalindrome4_ReturnTrue()
        {
            bool result = Str.IsPalindrome("A man, a plan, a canal: Panama.");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome_SentenceWithSpaces_ReturnTrue()
        {
            bool result = Str.IsPalindrome("                ");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void IsPalindrome_NoPalindrome_ReturnFalse()
        {
            bool result = Str.IsPalindrome("Hello world");
            Assert.AreEqual(false, result);
        }

        [Test]
        public void IsPalindrome_EmptyString_ReturnTrue()
        {
            bool result = Str.IsPalindrome("");
            Assert.AreEqual(true, result);
        }
    }
}

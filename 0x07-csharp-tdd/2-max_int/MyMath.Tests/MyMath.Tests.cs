using NUnit.Framework;
using System.Collections.Generic;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Max_CommonList_ReturnMaxInteger()
        {
            List<int> nums = new List<int> ();
            for (int i = 0; i < 10; i++)
            {
                nums.Add(i);
            }
            int result = Operations.Max(nums);
            Assert.AreEqual(9, result);
        }
        [Test]
        public void Max_ListWithOneElement_ReturnMaxInteger()
        {
            List<int> nums = new List<int> ();
            nums.Add(1);
            int result = Operations.Max(nums);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Max_ListWithNegativeElements_ReturnMaxInteger()
        {
            List<int> nums = new List<int> ();
            for (int i = 1; i < 10; i++)
            {
                nums.Add(i * -1);
            }
            int result = Operations.Max(nums);
            Assert.AreEqual(-1, result);
        }

        [Test]
        public void Max_EmptyList_ReturnZero()
        {
            List<int> nums = new List<int> ();
            int result = Operations.Max(nums);
            Assert.AreEqual(0, result);
        }
    }
}
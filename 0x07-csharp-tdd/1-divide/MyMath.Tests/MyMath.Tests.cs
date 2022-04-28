using System.Collections.Generic;
using NUnit.Framework;
using System;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Divide_PositiveIntegers_ReturnMatrixWithPositiveElements()
        {
            int[,] BeforeMatrix = new int[3, 2] {  { 9, 99 }, { 3, 33 }, { 5, 55 } };
            int[,] AfterMatrix = new int[3, 2] {  { 4, 49 }, { 1, 16 }, { 2, 27 } };
            var result = Matrix.Divide(BeforeMatrix, 2);
            Assert.AreEqual(result, AfterMatrix);
        }

        [Test]
        public void Divide_NegativeIntegers_ReturnMatrixWithNegativeElements()
        {
            int[,] BeforeMatrix = new int[3, 2] {  { -9, -99 }, { -3, -33 }, { -5, -55 } };
            int[,] AfterMatrix = new int[3, 2] {  { -4, -49 }, { -1, -16 }, { -2, -27 } };
            var result = Matrix.Divide(BeforeMatrix, 2);
            Assert.AreEqual(result, AfterMatrix);
        }

        [Test]
        public void Divide_SecondArgumentIsNegative_ReturnMatrixWithPositiveElements()
        {
            int[,] BeforeMatrix = new int[3, 2] {  { -9, -99 }, { -3, -33 }, { -5, -55 } };
            int[,] AfterMatrix = new int[3, 2] {  { 4, 49 }, { 1, 16 }, { 2, 27 } };
            var result = Matrix.Divide(BeforeMatrix, -2);
            Assert.AreEqual(result, AfterMatrix);
        }
        
        [Test]
        public void Divide_SecondArgumentIsNull_ReturnNull()
        {
            int[,] matrix = null;
            var result = Matrix.Divide(matrix, 2);
            Assert.AreEqual(result, null);
        }

        [Test]
        public void Divide_SecondArgumentIsZero_ReturnNull()
        {
            int[,] matrix = new int[3,2] {  { -9, -99 }, { -3, -33 }, { -5, -55 } };
            var result = Matrix.Divide(matrix, 0);
            Assert.AreEqual(result, null);
        }
    }
}
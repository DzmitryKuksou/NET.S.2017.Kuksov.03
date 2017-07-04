using NUnit.Framework;
using EqSumInArray;
using System;

namespace indexOfArrEqSum.Tests1
{
    /// <summary>
    /// Class TestEqSumInArr tests the method indexOfMedium(int[]) in class EqSumInArr.
    /// </summary>
    [TestFixture]
    public class TestEqSumInArr
    {
        /// <summary>
        /// test_indexOfMedium tests the method indexOfMedium(int[]) in class EqSumInArr
        /// </summary>
        /// <param name="array"></param>
        /// <returns>index of middle sum</returns>
        [TestCase(3, 1, 3, ExpectedResult = 1)]
        [TestCase(3, 1, 3, 1, 3, ExpectedResult = 2)]
        [TestCase(3, ExpectedResult = 0)]
        [TestCase(1, 2, 3, 4, 5, 1, 2, 3, 4, ExpectedResult = 4)]
        [TestCase(0, 0, 0, ExpectedResult = 0)]
        [TestCase(-2, 5, 4, 7, -8, 1, 10, -4, ExpectedResult = 5)]
        [TestCase(-1, 2, -2, 7, 9, 0, 2, -1, 19, -5, ExpectedResult = 5)]
        [TestCase(3, 1, ExpectedResult = -1)]
        public static int test_indexOfMedium(params int[] array)
        {
            return EqSumInArr.indexOfMediumOfSum(array);
            
        }
        /// <summary>
        /// test on Exception length = 0; 
        /// </summary>
        [TestCase(new int[0])]

        public static void test_indexOfMedium_Exception(params int[] array)
        {
            Assert.Throws<Exception>(() => EqSumInArr.indexOfMediumOfSum(array));
        }
        /// <summary>
        /// test on ArgumentNullException
        /// </summary>
        public static void test_indexOfMedium_ArgumentNullException(int[] array = null)
        {
            Assert.Throws<ArgumentNullException>(() => EqSumInArr.indexOfMediumOfSum(array));
        }
        /// <summary>
        /// test on ArgumentOutOfRangeException
        /// </summary>
        [Test]
        public static void test_indexOfMedium_ArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => EqSumInArr.indexOfMediumOfSum(new int[1001]));
        }
    }
}


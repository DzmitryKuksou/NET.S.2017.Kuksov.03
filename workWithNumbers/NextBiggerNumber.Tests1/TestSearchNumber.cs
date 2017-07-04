using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchNumbers;

namespace NextBiggerNumber.Tests1
{
    [TestFixture]
    public class TestSearchNumber
    {
        /// <summary>
        /// tests method NextBiggerNumber.
        /// </summary>
        /// <param name="num">number</param>
        /// <returns>number</returns>
        [TestCase(1234421, ExpectedResult = 1241234)]
        [TestCase(12, ExpectedResult = 21)]
        [TestCase(513, ExpectedResult = 531)]
        [TestCase(2017, ExpectedResult = 2071)]
        [TestCase(414, ExpectedResult = 441)]
        [TestCase(144, ExpectedResult = 414)]
        [TestCase(1234321, ExpectedResult = 1241233)]
        [TestCase(1234126, ExpectedResult = 1234162)]
        [TestCase(3456432, ExpectedResult = 3462345)]
        [TestCase(10, ExpectedResult = -1)]
        [TestCase(20, ExpectedResult = -1)]

        public int Test_NextBiggerNumber(int num)
        {
            return SearchIndex.NextBiggerNumber(num);
        }
        /// <summary>
        /// test on exception.
        /// </summary>
        /// <param name="num">number</param>
        [TestCase(-10)]
        public void FindNextBiggerNumber_ThrowsArgumentException(int num)
        {
            Assert.Throws<ArgumentException>(() => SearchIndex.NextBiggerNumber(num));
        }
    }
}

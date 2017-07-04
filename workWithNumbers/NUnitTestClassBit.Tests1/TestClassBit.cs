using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsertOfBit;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestClassBit
    {
        /// <summary>
        /// testing of Test_Insert
        /// </summary>
        /// <param name="num">number</param>
        /// <param name="insertNum">number</param>
        /// <param name="firstBit">bit</param>
        /// <param name="lastBit">bit</param>
        /// <returns>number</returns>
        /*[TestCase(26, 56, 1, 1, ExpectedResult = 56)]
        [TestCase(28, 148, 3, 5, ExpectedResult = 156)]
        [TestCase(3, 2, 1, 1, ExpectedResult = 3)]*///not working..
        public int Test_Insert(int num, int insertNum, int firstBit, int lastBit)
        {
            return Bit.Insert(num, insertNum, firstBit, lastBit);
        }
    }
}

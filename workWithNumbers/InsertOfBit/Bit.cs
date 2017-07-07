using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertOfBit
{
    public static class Bit
    {
        /// <summary>
        /// checking
        /// </summary>
        /// <param name="num">number</param>
        /// <param name="insertNum">number</param>
        /// <param name="firstBit">bit</param>
        /// <param name="lastBit">bit</param>
        public static void Checking(int num, int insertNum, int firstBit, int lastBit)
        {
            if (num <= 0 || insertNum <= 0 || firstBit <= 0 || lastBit <= 0) throw new ArgumentException("Numbers should be positive!");
            if (firstBit >= sizeof(int) * 4 || lastBit >= sizeof(int) * 4) throw new ArgumentException("Number of bits should be less then 32!");
            if (firstBit > lastBit) throw new ArgumentException("first bit must be less then last!");
        }
        /// <summary>
        /// insert of bits
        /// </summary>
        /// <param name="num">number</param>
        /// <param name="insertNum">number</param>
        /// <param name="firstBit">bit</param>
        /// <param name="lastBit">bit</param>
        public static int Insert(int num, int insertNum, int firstBit, int lastBit)
        {
            Checking(num, insertNum, firstBit, lastBit);
            int value = (int.MaxValue >> (firstBit - 1)) << (sizeof(int) * 4 - 2 + firstBit - lastBit) >> (sizeof(int) * -2 - lastBit);
            num &= value;
            insertNum &= value ^ int.MaxValue;
            return insertNum | num;
        }
    }
}
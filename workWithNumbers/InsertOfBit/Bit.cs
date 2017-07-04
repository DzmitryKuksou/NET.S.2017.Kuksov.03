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
        public static void Checked(int num, int insertNum, int firstBit, int lastBit)
        {
            if (num <= 0 || insertNum <= 0 || firstBit <=  0 || lastBit <= 0) throw new ArgumentException("Numbers should be positive!");
            if (firstBit > sizeof(int) * 4 || lastBit > sizeof(int) * 4) throw new ArgumentException("Bits should be less then 32!");
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
            Checked(num, insertNum, firstBit, lastBit);
            int a1 = 0;
            int a2 = 0;
            int a3 = insertNum;
            for (int i = sizeof(int) * 8 - 1; i >= 0; i--) 
            {
                if (i <= sizeof(int) * 8 - lastBit && i >= sizeof(int) * 8 - firstBit)
                {
                    a2 |= 1;
                    if ((num & 1) == 1)
                    {
                        a1 |= 1;
                    }
                    insertNum >>= 1;
                    a1 <<= 1;
                    a2 <<= 1;
                    num >>= 1;
                }

                else
                {
                    num >>= 1;
                    a1 |= 1;
                    a1 <<= 1;
                    if((insertNum & 1) == 1)
                    {
                        a2 |= 1;
                    }
                    a2 <<= 1;
                }
            }


            return a1&=a2 ;
        }

    }
}

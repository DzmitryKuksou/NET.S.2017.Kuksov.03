using System;

namespace EqSumInArray
{
    public static class EqSumInArr
    {
        /// <summary>
        /// Method indexOfMediumOfSum(int[]) search index element of array, which has the same sum of elmenets on right and left sides.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>index element of array.</returns>
        public static int indexOfMediumOfSum(params int[] array)
        {
            if (ChecksDimension(array) == true) return 0;
            int left = 0;
            int right = 0;
            for (int i = 1; i <= array.Length - 1; i++)
            {
                for (int i1 = i - 1; i1 >= 0; i1--)
                {
                    left += array[i1];
                }
                
                for (int i2 = i + 1; i2 < array.Length; i2++)
                {
                    right += array[i2];
                }
                if (IsEqual(left, right) == true) return i;
                left = 0;
                right = 0;
            }
            return -1;
        }

        /// <summary>
        /// checking on null referenes, null, big dimension....
        /// </summary>
        /// <param name="array">array</param>
        /// <returns>true or false</returns>
        private static bool ChecksDimension(int[] array)
        {
            if (array == null) throw new ArgumentNullException("error!");
            if (array.Length == 0) throw new Exception("array is empty!");
            if (array.Length > 1000) throw new ArgumentOutOfRangeException("Array's length is more than 1000!");
            if (array.Length == 1) return true;
            if (sumOfArrayIsNull(array) == true) return true;
            else return false;
        }
        /// <summary>
        /// Method sumOfArrayIsNull calculate the sum of elements in array.
        /// </summary>
        /// <param name="array"></param>
        /// <returns>sum of elements in array.</returns>
        private static bool sumOfArrayIsNull(int[] array)
        {
            int sum = 0;
            foreach (int el in array)
            {
                sum += el;
            }
            if (sum == 0) return true;
            else return false;

        }
        /// <summary>
        /// Checking of two sums
        /// </summary>
        /// <param name="sum1"></param>
        /// <param name="sum2"></param>
        /// <returns>true or false</returns>
        private static bool IsEqual(int sum1, int sum2)
        {
            if (sum1 == sum2) return true;
            return false;

        }
    }
}
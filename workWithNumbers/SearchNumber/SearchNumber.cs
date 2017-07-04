using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchNumbers
{
    public static class SearchIndex
    {
        /// <summary>
        /// find Next Bigger Number
        /// </summary>
        /// <param name="num">number</param>
        /// <returns>number</returns>
        public static int NextBiggerNumber(int num)
        {
            CheckNum(num);
            int []array = NumToArr(num);
            if (CheckArr(array) == false) return -1;
            SortArrForSearchNum(array);
            if (num != ArrayToNum(array))
            {
                num = ArrayToNum(array);
                return num;
            }
            return -1;
        }
        /// <summary>
        /// convert number to array
        /// </summary>
        /// <param name="array">array</param>
        /// <returns>number</returns>
        private static int ArrayToNum(int[] array)
        {
            int num = 0;
            for (int i = 0; i < array.Length; i++)
            {
                num += array[i];
                num *= 10;
            }
            return num / 10;
        }
        /// <summary>
        /// checking number
        /// </summary>
        /// <param name="num">number</param>
        private static void CheckNum(int num)
        {
            if (num < 0) throw new ArgumentException("Number less than 0!");
        }
        /// <summary>
        /// sort
        /// </summary>
        /// <param name="array">array</param>
        private static void SortArrForSearchNum(int[] array)
        {
            for (int i = array.Length - 1; i - 1 >= 0; i--)
            {
                if (array[i] > array[i - 1])
                {
                    Swap(ref array[i], ref array[i - 1]);
                    QuickSort(array, i, array.Length - 1);
                    break;
                }
            }
        }
        /// <summary>
        /// checking dimension
        /// </summary>
        /// <param name="array">array</param>
        /// <returns></returns>
        private static bool CheckArr(int[] array)
        {
            if (array.Length == 1) return false;
            return true;
        }
        /// <summary>
        /// convert number to array
        /// </summary>
        /// <param name="num">number</param>
        /// <returns>array</returns>
        private static int[] NumToArr(int num)
        {
            int length = 0;
            int temp = num;
            while (temp != 0)
            {
                length++;
                temp /= 10;
            }
            int[] array = new int[length];
            while (num != 0) 
            {
                array[length - 1] = num % 10;
                num /= 10;
                length--;
            }
            return array;
        }
        /// <summary>
        /// Quicksort
        /// </summary>
        /// <param name="a">array</param>
        /// <param name="l">first el</param>
        /// <param name="r">last el</param>
        private static int QuickSort(int[] a, int l, int r)
        {
            int x = a[l + (r - l) / 2];
            int i = l;
            int j = r;
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    Swap(ref a[j], ref a[i]);
                }
            }
            if (i < r)
                QuickSort(a, i, r);

            if (l < j)
                QuickSort(a, l, j);
           return 0;
        }
        /// <summary>
        /// swap two param.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }
    }
}

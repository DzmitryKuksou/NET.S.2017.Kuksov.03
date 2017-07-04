using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class Sorts
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">array</param>
        /// <param name="l">first el</param>
        /// <param name="r">last el</param>
        public static void QuickSort(int[] a, int l, int r)
        {
            int t;
            int x = a[l + (r - l) / 2];
            int i = l;
            int j = r;
            while (i <= j)
            {
                while (a[i] < x) i++;
                while (a[j] > x) j--;
                if (i <= j)
                {
                    t = a[i];
                    a[i] = a[j];
                    a[j] = t;
                    i++;
                    j--;
                }
            }
            if (i < r)
                QuickSort(a, i, r);

            if (l < j)
                QuickSort(a, l, j);
        }
        public static void QuickSort(int[] a)
        {
            QuickSort(a, 0, a.Length - 1);
        }
        public static void MergeSort(int[] a)
        {
            ValidInput(a);
            MergeSort(a, 0, a.Length - 1);
        }
        #region Merge
        /// <summary>
        /// mergesort
        /// </summary>
        /// <param name="a">array</param>
        /// <param name="first">first el</param>
        /// <param name="last">last el</param>
        public static void Merge(int[] a, int first, int last)
        {
            int middle, start, final, j;
            int[] mas = new int[a.Length];

            middle = (first + last) / 2;
            start = first;
            final = middle + 1;

            for (j = first; j <= last; j++)
                if ((start <= middle) && ((final > last) || (a[start] < a[final])))
                {
                    mas[j] = a[start];
                    start++;
                }
                else
                {
                    mas[j] = a[final];
                    final++;
                }

            for (j = first; j <= last; j++)
                a[j] = mas[j];
        }
        #endregion
        #region MergeSort
        /// <summary>
        /// mergesort
        /// </summary>
        /// <param name="a">array</param>
        /// <param name="first">first el</param>
        /// <param name="last">last el</param>
        public static void MergeSort(int[] a, int first, int last)
        {
            {
                if (first < last)
                {
                    MergeSort(a, first, (first + last) / 2);
                    MergeSort(a, ((first + last) / 2) + 1, last);
                    Merge(a, first, last);
                }
            }
        }
        #endregion
        #region ValidInput
        /// <summary>
        /// checking array
        /// </summary>
        /// <param name="a">array</param>
        private static void ValidInput(int[] a)
        {
            if (a.Length == 0) throw new NullReferenceException("Array is empty!");
            if (a == null) throw new NullReferenceException("Null!");
        }
        #endregion

    }
}

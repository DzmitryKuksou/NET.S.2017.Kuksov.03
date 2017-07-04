using NUnit.Framework;
using Sorting;

namespace NUnit.Tests1
{
    [TestFixture]
    public class TestSorts
    {
        /// <summary>
        /// Testing of quicksort
        /// </summary>
        /// <param name="arr">array</param>
        /// <returns>Sored Array</returns>
        [TestCase(6, 2, 3, 4, ExpectedResult = new int[] {2,3,4,6})]
        [TestCase(0, 2, 0, -1, 45, ExpectedResult = new int[] { -1, 0, 0, 2, 45 })]
        [TestCase(62, -2, 0, 3, 4, -22, 33, ExpectedResult = new int[] { -22, -2, 0, 3, 4, 33, 62 })]
        [TestCase(1, 2, 1, 1, 1, 0, ExpectedResult = new int[] {0, 1, 1, 1, 1, 2})]
        [TestCase(6, 2, 3, 4, 3, 1, 2, -2, -10, ExpectedResult = new int[] { -10, -2, 1, 2, 2, 3, 3, 4, 6 })]
        public int[] test_Quicksort(params int[] array)
        {
            Sorts.QuickSort(array);
            return array;
        }
        /// <summary>
        /// Teststing of MergeSort
        /// </summary>
        /// <param name="array">array</param>
        /// <returns>Sorted Array</returns>
        [TestCase(6, 2, 3, 4, ExpectedResult = new int[] { 2, 3, 4, 6 })]
        [TestCase(0, 2, 0, -1, 45, ExpectedResult = new int[] { -1, 0, 0, 2, 45 })]
        [TestCase(62, -2, 0, 3, 4, -22, 33, ExpectedResult = new int[] { -22, -2, 0, 3, 4, 33, 62 })]
        [TestCase(1, 2, 1, 1, 1, 0, ExpectedResult = new int[] { 0, 1, 1, 1, 1, 2 })]
        [TestCase(6, 2, 3, 4, 3, 1, 2, -2, -10, ExpectedResult = new int[] { -10, -2, 1, 2, 2, 3, 3, 4, 6 })]
        public static int[] test_MergeSort(params int[] array)
        {
            Sorts.MergeSort(array);
            return array;
        }
    }
}

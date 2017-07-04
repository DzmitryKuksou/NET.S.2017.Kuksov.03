using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            int size;
            size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                a[i] = rnd.Next(1, 100);
            }
            Sorts.MergeSort(a, 0, size - 1);

            for (int i = 0; i < size; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}


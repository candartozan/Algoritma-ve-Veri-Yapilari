﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.SortingAlgorithms
{
    public class QuickSort
    {
        public static void Sort<T>(T[] array)where T :IComparable
        {
            Sort(array, 0, array.Length - 1);
        }
        private static void Sort<T>(T[] array, int lower, int upper) where T:IComparable
        {
            if (lower < upper)
            {
                int pi = Partition(array, lower, upper);
                Sort(array, lower, pi);
                Sort(array, pi+1,upper);
            }
        }
        private static int Partition<T>(T[] array, int lower, int upper) where T : IComparable
        {
            int i = lower;
            int j = upper;
            T pivot = array[lower];
            do
            {
                while (array[i].CompareTo(array[j]) < 0)
                {
                    i++;
                }
                while (array[j].CompareTo(array[i]) > 0)
                {
                    j--;
                }
                if (i > j)
                    break;
                Sorting.Swap<T>(array, i, j);

            } while (i<=j);
            return j;
        }
    }
}
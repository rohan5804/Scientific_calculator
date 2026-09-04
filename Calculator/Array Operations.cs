using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Array_Operations
    {
        public static int[] sort_array_ascending(int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }

        public static int[] sort_array_descending(int[] arr)
        {
            Array.Sort(arr);
            Array.Reverse(arr);
            return arr;
        }

        public static int maximum(int[] arr)
        {
            return arr.Max();
        }

        public static int minimum(int[] arr) {
            return arr.Min();
        }

        public static int sum(int[] arr)
        {
            return arr.Sum();
        }

        public static double average(int[] arr)
        {
            return arr.Average();
        }

        public static bool contains(int[] arr, int value)
        {
            return arr.Contains(value);
        }
    }
}

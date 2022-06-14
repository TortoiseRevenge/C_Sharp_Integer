using System;
using System.Collections.Generic;

namespace C_Sharp_SourceControl_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int [] array = new int[] {1, 2, 3, 4, 5, 6, 7, 8};
            even(array);
        }
        private static List<int> even(int[] array)
        {
            List <int> results = new List<int>();
            for (int i = 0; i < array.Length; i++) {
                if (array[i] % 2 == 0) {
                    Console.WriteLine(array[i]);
                }
            }
            return results;
        }
        private static List<int> odd(int[] array)
        {
            List <int> results = new List<int>();
            for (int i = 0; i < array.Length; i++) {
                if (array[i] % 2 == 1) {
                    Console.WriteLine(array[i]);
                }
            }
            return results;
        }
    }
}
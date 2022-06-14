using System;
using System.Collections.Generic;

namespace C_Sharp_SourceControl_2
{
    class Program
    {
        public static void Main(string[] args)
        {
             int[] nums = {1, 3, 5, 7, 9 };
             sum(nums);
             Console.WriteLine(sum(nums));

        }
        private static void function()
        {
            return;
        }
        private static int sum(int[] numbers)
        {
            int sum=0;
               for (int i =0; i<numbers.Length; i++){
                    sum+=numbers[i];
               }
               return sum;

        }
    }
}
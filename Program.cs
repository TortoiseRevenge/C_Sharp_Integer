using System;
using System.Collections.Generic;

namespace C_Sharp_SourceControl_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            foreach(int i in divByThree(array2)){
            Console.WriteLine(i);
            }
            foreach(int i in everyFifth(array2)){
            Console.WriteLine(i);
            }
             int[] nums = {1, 3, 5, 7, 9 };
             sum(nums);
             Console.WriteLine(sum(nums));

            int [] array = new int[] {1, 2, 3, 4, 5, 6, 7, 8};
            even(array);
            odd(array);
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
        public static List<int> divByThree(int[] array)
        {
            List<int> result = new List<int>();
            foreach(int i in array){
                if(i%3 == 0){
                    result.Add(i);
                }
            }
            return result;
        }
        public static List<int> everyFifth(int[] array){
            int count = 1;
            List<int> result = new List<int>();
            foreach(int i in array){
                if (count%5 == 0){
                    result.Add(i);
                    count++;
                }
                else{
                    count++;
                }
            }
            return result;
        }
        private static int sum(int[] numbers)
        {
            int sum=0;
               for (int i =0; i<numbers.Length; i++){
                    sum+=numbers[i];
               }
               return sum;

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
using System;
using System.Collections.Generic;

namespace C_Sharp_SourceControl_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How many integers?");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[x];
            int z = 0;
            foreach (int i in array)
            {
                Console.WriteLine("Enter an integer: ");
                array[z] = Convert.ToInt32(Console.ReadLine());
                z ++;
            }
            Display(array);
        }
        private static void Display(int[] v)
        {
            Console.Write("Numbers that you entered: ");
            for(int x = 0; x < v.Length; x ++)
            {
                Console.Write(v[x] + " ");
            }
            Console.Write("\n");
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
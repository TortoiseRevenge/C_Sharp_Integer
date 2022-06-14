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
    }
}
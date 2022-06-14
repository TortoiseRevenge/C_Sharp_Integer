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
    }
}
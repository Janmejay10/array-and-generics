using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class Array4
    {
        static void printArray(int[] arr1, int[] arr2)
        {
            Console.WriteLine("Printing array 1 elements:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.WriteLine("Printing array 2 elements:");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array 1:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            Console.WriteLine("enter the array elements");
            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter the size of array 2:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[m];
            Console.WriteLine("enter the array elements");
            for (int i = 0; i < m; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }

            printArray(arr1, arr2);        // here we are passing array to function  

            Console.Read();
        }
    }
}

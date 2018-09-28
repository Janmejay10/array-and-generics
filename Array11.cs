using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class Array11                //removing uncommon elements in 2 arrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array 1:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            Console.WriteLine("enter the array1 elements");
            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter the size of array 2:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] arr2 = new int[m];
            Console.WriteLine("enter the array2 elements");
            for (int i = 0; i < m; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            int l = n + m;
            int[] z = new int[l];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                z[count++] = arr1[i];
            }
            for (int i = 0; i < m; i++)
            {
                z[count++] = arr2[i];
            }
            Console.WriteLine("combined final array:");
            for (int i = 0; i < l; i++)
            {
                Console.Write(z[i] + ",");
                
            }
            Console.Read();
        }
    }
}

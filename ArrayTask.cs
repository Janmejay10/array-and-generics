using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class ArrayTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("enter the array elements");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] arr1 = arr.Distinct().ToArray();

            Console.WriteLine(" new array elements are");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.Read();

        }
    }
}

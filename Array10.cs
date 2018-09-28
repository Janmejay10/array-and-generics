using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class Array10
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
            Console.WriteLine();

            for (int i = 0; i < n / 2; i++)
            {
                arr[i] = arr[i] + arr[n - i - 1];
                arr[n - i - 1] = arr[i] - arr[n - i - 1];
                arr[i] = arr[i] - arr[n - i - 1];
            }
            Console.WriteLine("reversed array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] +  " ,");
            }
            Console.Read();

        }
    }
}

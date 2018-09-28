using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class Array7                  // first half sum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter the size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("enter the array elements");
            for (int i = 0; i < n / 2; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];

            }

            Console.WriteLine("average of the array elements is: " + sum);
            Console.Read();
        }
    }
}

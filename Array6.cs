using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class Array6                      // average of array elements at even indexes
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.WriteLine("enter the size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("enter the array elements");
            for (int i = 0; i < n; i = i + 2)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];

            }
            double avg = sum / (n / 2);

            Console.WriteLine("average of the array elements is: " + avg);
            Console.Read();
        }
    }
}
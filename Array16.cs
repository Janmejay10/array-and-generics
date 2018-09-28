using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class Array16                   // rank and length of jagged array
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 10, 20, 30, 40, 50, 60, };
            Console.WriteLine("elements of array:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n enter new size of the array:");
            int n = Convert.ToInt32(Console.ReadLine());

            Array.Resize(ref arr, n);
            Console.WriteLine("elements of new array array:");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n length of array is:" + arr.Length);
            Console.WriteLine("\n Rank of array is:" + arr.Rank);
            Console.Read();


        }
    }
}

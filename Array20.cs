using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class Array20
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
            Console.WriteLine("array elements are");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Array.Sort(arr);
            Console.WriteLine("array elements after sorting are");
            foreach (int i in arr)
            {
                Console.WriteLine(i + " ");
            }
            Console.Read();







        }
    }
}

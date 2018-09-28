using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class Array1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the size of array");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[x];
            arr[0] = 10;
            arr[2] = 20;
            arr[4] = 30;


            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                Console.Read();
            }
        }
    }
}

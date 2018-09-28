using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class Array12
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[4] { 10, 20, 30, 40 };
            arr[1] = new int[2] { 50, 60};
            arr[2] = new int[3] { 70, 80, 90};
            Console.WriteLine("elements of this jagged array:");
            for(int r = 0; r < arr.Length; r++)
            {
                for(int c = 0; c < arr[r].Length;c++)
                {
                    Console.Write(arr[r][c] + " ");
                }
                Console.WriteLine();

            }
            Console.Read();
        }
    }
}

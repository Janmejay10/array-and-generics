using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class Array13                //   previous program by foreach
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[4] { 10, 20, 30, 40 };
            arr[1] = new int[2] { 50, 60 };
            arr[2] = new int[3] { 70, 80, 90 };
            Console.WriteLine("elements of this jagged array:");
            
             foreach(int[] r in arr)
            {
                foreach(int c in r)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class Array14                    // using dyamic array, changing array size at runtime
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 10, 20, 30, 40, 50, 60,};
            Console.WriteLine("elements of array:");
            foreach(int i in arr)
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
            Console.Read();


        }
    }
}

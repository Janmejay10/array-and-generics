using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class ArrayTask1
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
            int count = 0;
            for (int i = 0; i < n - count; i++)
            {
                for (int j = i + 1; j < n - count; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        for (int k = j; k < n - count - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }
                        count++;
                        j--;
                    }
                }
            }
            
            int[] arr1 = new int[n - count];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = arr[i];
            }
          Console.WriteLine(" correct array elements are");
            for (int i = 0; i < n-count; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.Read();

        }
    }
}

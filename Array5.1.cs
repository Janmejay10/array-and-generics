using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class Array55
    {
        
    public static void Main(string[] args)
        {
            Console.WriteLine("enter the rows:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enetr the columns:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[m, n];
            Console.WriteLine("enter the array elements :");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine("2-D array elements are:");
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            Console.Read();
        }
    }
}


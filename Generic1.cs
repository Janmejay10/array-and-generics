using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class Generic1                   // program for generic function
    {
        static void display<G>(G s)
        {
            Console.WriteLine("value of s is :" + s);
        }
        static void Main(string[] args)
        {
            display<int>(10);
            display<string>("hello");
            display<double>(10.5);
            Console.Read();
        }
    }
}

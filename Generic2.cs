using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class Generic2<G>
    {
        public void display(G s)
        {
            Console.WriteLine("the value of s is:" + s);
        }
    }
        class Generic3
    {
        static void Main(string[] args)
        {
            Generic2<string> obj1 = new Generic2<string>();
            Generic2<int> obj2 = new Generic2<int>();
            Generic2<double> obj3 = new Generic2<double>();

            obj1.display("jay");
            obj2.display(19);
            obj3.display(56.85);
            Console.Read();

        }
    }
    
        
 }


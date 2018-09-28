using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_generics
{
    class Generic4<G1,G2>
    {
        public void display(G1 s1,G2 s2)
        {
            Console.WriteLine("the values of s1 and s2 are:{0},{1}", s1 , s2);
        }
    }
    class Generic5
    {
        static void Main(string[] args)
        {
            Generic4<string,int> obj1 = new Generic4<string,int>();
            Generic4<int,float> obj2 = new Generic4<int,float>();
            Generic4<double,string> obj3 = new Generic4<double,string>();

            obj1.display("jay",45);
            obj2.display(19,85f);
            obj3.display(56.85,"bonsuer");
            Console.Read();

        }
    }


}


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();

            list.Add("some string");
            //Console.WriteLine(list[0].length);

            String s = (String)list[0];
            Console.WriteLine(s.Length);

            //    int i = 123;
            //    object o = i;

            //    i = (int)o;
        }
    }
}

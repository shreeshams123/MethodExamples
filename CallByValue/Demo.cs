using System;
using System.Collections.Generic;
using System.Text;

namespace CallByValue
{
    class Demo
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            Modify(a);
            foreach(var i in a)
            {
                Console.WriteLine(i);
            }
        }
        static void Modify(int[] a)
        {
            a[0] = 5;
        }
    }
}

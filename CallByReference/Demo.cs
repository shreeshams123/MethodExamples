using System;
using System.Collections.Generic;
using System.Text;

namespace CallByReference
{
    class Demo
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Modify(ref a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

            static void Modify(ref int[] a)
            {
                a = new int[] { 5, 6, 7 };
            }
        }
    }
}
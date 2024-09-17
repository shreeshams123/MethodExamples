using System;

namespace CallByReference
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 20;
            Console.WriteLine("Before"+num);
            Modify(ref num);
            Console.WriteLine("After"+num);
        }
        static void Modify(ref int num)
        {
            num = 10;
        }
    }
}

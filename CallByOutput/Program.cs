using System;

namespace CallByOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Modify(out num);
            Console.WriteLine(num);
        }
        static void Modify(out int num)
        {
            num = 20;
        }
    }
}

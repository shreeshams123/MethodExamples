using System;

namespace CallByValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 20;
            Console.WriteLine("Before Modification:{0}",num);
           int num2= Modify(num);
            Console.WriteLine(num2);
            Console.WriteLine("After Modification:" + num);

        }
        static int Modify(int num)
        {
            return num = 10;
        }
    }
}

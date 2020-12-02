using System;

namespace Sample405
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num;
            num = 1;
            Console.Write("whileで実行");
            i = 1;
            while (i < num)
            {
                Console.Write("*");
                i++;
            }
            Console.WriteLine();

            Console.Write("do~while文で実行");
            i = 1;
            do
            {
                Console.WriteLine("*");
                i++;
            } while (i < num);
        }
    }
}

using System;

namespace Exercise402
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数を入力:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1;  i < num; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
            Console.WriteLine();
        }
    }
}

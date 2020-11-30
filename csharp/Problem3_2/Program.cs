using System;

namespace Problem3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力してください");
            int a = int.Parse(Console.ReadLine());
            if (30<a | a<70)
            {
                Console.WriteLine("30より大きく70以下です");
            }
            else
            {
                Console.WriteLine("たこ");
            }



        }
    }
}

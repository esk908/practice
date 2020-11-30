using System;

namespace Sample304
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("さいころの目(1~6):");

            int dice = int.Parse(Console.ReadLine());

            if(1 <= dice && dice <= 6)
            {
                if(dice == 2 || dice == 4 || dice == 6)
                {
                    Console.WriteLine("丁です。");
                }
                else
                {
                    Console.WriteLine("半です。");
                }
            }
            else
            {
                Console.WriteLine("範囲外の数値です");
            }
        }
    }
}
//if文のネスト　何かの処理の中にさらに何かの処理が入っているのがネスト
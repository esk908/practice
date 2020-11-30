using System;

namespace Sample303
{
    class Program
    {
        static void Main(string[] args)
        {
            //  キーボードから数値を入力
            Console.Write("1から3の整数値を入力:");
            int num = int.Parse(Console.ReadLine());
            if(num == 1)
            {
                Console.WriteLine("ONE");
            }
            else if(num == 2)
            {
                Console.WriteLine("TWO");
            }
            else if(num == 3)
            {
                Console.WriteLine("Three");
            }
            else
            {
                Console.WriteLine("不適切な値です。");
            }
        }
    }
}
//else if 
//ifとelseだけでは一つの条件が成り立った時それ以外に場合の処理しか実行できませんが以上の結果の様に、else ifを用いれば複数の条件の場合わけが可能

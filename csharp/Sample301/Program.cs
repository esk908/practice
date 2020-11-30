using System;

namespace Sample301
{
    class Program
    {
        static void Main(string[] args)
        {
            // キーワードから数値を入力
            Console.Write("整数値を入力");
            int a = int.Parse(Console.ReadLine()); //コンソールからの文字列を、数値に変換している
            Console.WriteLine("a=" + a);　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　　
            //入力した値が、正の数かどうかしてべる
            if(a > 0)
            {
                Console.WriteLine("aは正の数です");//正の数だった場合に実行
            }

        }
    }
}

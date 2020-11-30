using System;

namespace problem3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力してください");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a=" + a);

            if(a==3)
            {
                Console.WriteLine("aは3です。");
            }
          
        }
    }
}

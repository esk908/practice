using System;

namespace Problem3_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列１を入力");
            string a = (Console.ReadLine());

            Console.Write("文字列2を入力");
            string b = (Console.ReadLine());

            if(a==b)
            {
                Console.WriteLine("二つの文字列は等しい");
            }
            else
            {
                Console.WriteLine("二つの文字列は等しくない");
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample302
{
    class Program
    {
        static void Main(string[] args)
        {
            //キーワードから数値を入力
            Console.Write("整数値を入力");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a=" + a);
            //入力した値が正の数かどうか調べる
            if (a > 0)
            {
                Console.WriteLine("aは正の数です。");
            }
            else
            {
                Console.WriteLine("aは正の数ではありません。");
            }
        }
    }
}

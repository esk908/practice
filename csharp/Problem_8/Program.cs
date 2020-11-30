using System;

namespace Problem3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1から4の数字を入力");
            int num = int.Parse(Console.ReadLine());
            switch(num)
            {
                case 1:
                    Console.WriteLine("春");  
                    break;
                case 2:
                    Console.WriteLine("夏");    
                    break;
                case 3:
                    Console.WriteLine("秋");  
                    break;
                case 4:
                    Console.WriteLine("冬"); 
                    break;
                default:
                    Console.WriteLine("例外");
                    break;
            }
        }
    }
}

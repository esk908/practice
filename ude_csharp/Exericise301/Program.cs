using System;

namespace Exericise301
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp  = double.Parse(Console.ReadLine());

            Console.WriteLine(temp);

            if(temp==0)
            {
                Console.WriteLine(0);
            }
            else if(temp > 0.0)
            {
                Console.WriteLine("ゼロより大きい");
            }
            else
            {
                Console.WriteLine("ゼロより小さい");
            }


        }
    }
}

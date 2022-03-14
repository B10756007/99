using System;

namespace _99乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("99乘法表");

            for(int i = 1; i <= 9 ; i++)
            {
                for (int j = 1; j<=9; j++)
                {
                    Console.WriteLine(i + "*" + j + "=" + i * j );
                }
                Console.Write("\r\n");
            }
        }
    }
}

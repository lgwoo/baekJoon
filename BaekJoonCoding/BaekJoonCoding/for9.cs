using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonCoding
{
    class for9
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonCoding
{
    class for1
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            for(int b = 1; b<10; b++)
            {
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            }
        }
    }
}

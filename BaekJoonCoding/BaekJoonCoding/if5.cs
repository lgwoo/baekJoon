using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonCoding
{
    class if5
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (b >= 45)
            {
                b -= 45;
            }
            else if (a > 0)
            {
                a -= 1; b += 15;
            }
            else
            {
                a = 23; b += 15;
            }
            Console.WriteLine(a , b);
        }
    }
}

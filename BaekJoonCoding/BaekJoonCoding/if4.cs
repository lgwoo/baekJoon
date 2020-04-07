using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonCoding
{
    class if4
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                if (b > 0)
                {
                    Console.WriteLine(1);
                }
                else { Console.WriteLine(4); }
            }
            else
            {
                if (b > 0)
                {
                    Console.WriteLine(2);
                }
                else { Console.WriteLine(3); }
            }
        }
    }
}

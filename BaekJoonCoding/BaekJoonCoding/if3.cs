using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonCoding
{
    class if3
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());

            if (((a % 4 == 0) && (a % 100 != 0)) || (a % 400 == 0))
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");

            }
        }
    }
}

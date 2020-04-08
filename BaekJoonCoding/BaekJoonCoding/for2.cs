using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonCoding
{
    class for2
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());

            for( int i = 0; i < a; i++)
            {
                string[] d = Console.ReadLine().Split();
                int b = int.Parse(d[0]);
                int c = int.Parse(d[1]);
                Console.WriteLine(b + c);
            }
        }

    }
}

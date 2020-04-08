using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonCoding
{
    class for3
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int k = 0;
            for(int i = 0; i<=a; i++)
            {
                k = k+i;
            }
            Console.WriteLine(k);

            // Console.WriteLine((a*(a+1))/2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonCoding
{
    class while2
    {
        static void Main()
        {
            for (; ; )
            {
                string s = Console.ReadLine();
                if (s == null)
                {
                    break;
                }
                string[] ss = s.Split();
                int a = int.Parse(ss[0]);
                int b = int.Parse(ss[1]);
                Console.WriteLine(a + b);
            }
        }
    }

}
 
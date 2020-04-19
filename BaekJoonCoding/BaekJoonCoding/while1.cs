using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonCoding
{
    class while1
    {
        static void Main()
        {
            bool a = true;
            var bilder = new StringBuilder();
            while (a)
            {
                string[] n = Console.ReadLine().Split();
                int x = int.Parse(n[0]);
                int y = int.Parse(n[1]);
                if (x == 0 && y == 0)
                {
                    a = false;
                }
                else  {Console.WriteLine(x + y);
}
            }
        }
    }
}

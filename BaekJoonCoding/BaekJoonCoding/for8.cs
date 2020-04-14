using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonCoding
{
    class for8
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= a; i++)
            {
                string[] k = Console.ReadLine().Split();
                int x = int.Parse(k[0]);
                int y = int.Parse(k[1]);
                int r = x + y;
                sb.AppendLine(("Case #" + i + ": " + x + " + " + y + " = " + r));
            }
            Console.WriteLine(sb);
        }
    }
}

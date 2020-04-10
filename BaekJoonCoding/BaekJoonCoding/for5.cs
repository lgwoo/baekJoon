using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonCoding
{
    class for5
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= a; ++i)
            {
                sb.AppendLine(i.ToString());
            }
            Console.WriteLine(sb);
        }
    }
}

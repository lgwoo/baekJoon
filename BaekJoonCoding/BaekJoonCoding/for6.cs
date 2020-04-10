using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonCoding
{
    class for6
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int i = 0; a > i; i++)
            {
                sb.AppendLine((a - i).ToString());
            }
            Console.WriteLine(sb);
        }
    }
}

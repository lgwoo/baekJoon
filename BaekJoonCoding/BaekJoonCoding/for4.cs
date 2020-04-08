using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace BaekJoonCoding
{
    class for4
    {
        static void Main()
        {
            // 미해결.. StringBuilder 와 SteamReader사용법을 공부해야 함!!
            int a = int.Parse(Console.ReadLine());
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < a; i++)
            {
                string[] d = Console.ReadLine().Split();
                int b = int.Parse(d[0]);
                int c = int.Parse(d[1]);
                int k = b + c;
                stringBuilder.Append(k);
            }
            Console.WriteLine(stringBuilder);

        }

    }
}

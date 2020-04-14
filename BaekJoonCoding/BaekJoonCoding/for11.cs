using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonCoding
{
    class for11
    {
        static void Main()
        {
            string[] arryCountMaxNum = Console.ReadLine().Split(" ");
            int arryCount = int.Parse(arryCountMaxNum[0]);
            int maxNum = int.Parse(arryCountMaxNum[1]);

            string[] arryString = Console.ReadLine().Split(" ");

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < arryCount; i++)
            {
                if(maxNum > int.Parse(arryString[i]))
                {
                    builder.Append(arryString[i]);
                    builder.Append(" ");
                }
            }
            Console.WriteLine(builder);
            
        }
    }
}
/*  foreach를 사용한 답
        var inp1 = Console.ReadLine().Split(' ');
        var inp2 = Console.ReadLine().Split(' ');

        var x = int.Parse(inp1[1]);
        var sb = new StringBuilder();

        foreach(var n in inp2)
        {
            if(int.Parse(n) < x)
            {
                sb.Append(n);
                sb.Append(' ');
            }
        }
        
        Console.WriteLine(sb);
    }
}
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace BaekJoonCoding
{
    class for10
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                for (int j = i; j < a; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
/* 모범 답안
 * using System;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int n = int.Parse(input);
        StringBuilder result = new StringBuilder();
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < n - i; j++)
            {
                result.Append(" ");
            }
            for (int j = 0; j < i; j++)
            {
                result.Append("*");
            }
            result.AppendLine();
        }
        Console.Write(result.ToString());
    }
}
*/

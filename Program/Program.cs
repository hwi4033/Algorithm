using System;
using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 496;
            int temp = 0;
            int[] ary = new int[];

            for (int i = 1; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    temp += i;
                }
            }

            if (num == temp)
            {
                Console.WriteLine(num + "는 완전수이다.");
            }
            else
            {
                Console.WriteLine(num + "는 완전수가 아니다.");
            }
        }
    }
}
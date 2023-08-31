using System;

namespace RecursiveCountdown
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(Countdown(n));
        }

        static string Countdown(int n)
        {
            if (n == 1)
            {
                return "1";
            }
            return n + ", " + Countdown(n - 1);
        }
    }
}

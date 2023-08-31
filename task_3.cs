using System;

namespace AckermannFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int m1 = 2, n1 = 3;
            int result1 = Ackermann(m1, n1);
            Console.WriteLine($"A({m1}, {n1}) = {result1}");

            int m2 = 3, n2 = 2;
            int result2 = Ackermann(m2, n2);
            Console.WriteLine($"A({m2}, {n2}) = {result2}");
        }

        static int Ackermann(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return Ackermann(m - 1, 1);
            }
            else if (m > 0 && n > 0)
            {
                return Ackermann(m - 1, Ackermann(m, n - 1));
            }
            else
            {
                throw new ArgumentException("Некорректные значения m и n.");
            }
        }
    }
}

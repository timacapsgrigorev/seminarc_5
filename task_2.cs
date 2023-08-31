using System;

namespace SumOfNaturalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int M = 1, N = 15;
            int sum = CalculateSum(M, N);
            Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {sum}");
        }

        static int CalculateSum(int start, int end)
        {
            if (end < start)
            {
                throw new ArgumentException("Конечное значение должно быть больше или равно начальному.");
            }

            if (start == end)
            {
                return start;
            }
            else
            {
                return start + CalculateSum(start + 1, end);
            }
        }
    }
}

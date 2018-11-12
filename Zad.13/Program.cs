
// Напишете програма, която пресмята сумата (с точност до 0.001):1 + 1/2 - 1/3 + 1/4 - 1/5 + ...

using System;


namespace Zad._13
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 1.0;

              for (int i = 2; i <= n; i++)
              {
                sum += (1.0 / i);
              }

            Console.WriteLine(" Сумата на числата е {0:F3}", sum);
        }
    }
}

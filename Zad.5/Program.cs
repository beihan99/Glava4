
// Напишете програма, която чете от конзолата две цели числа (int) и отпечатва, колко числа има между тях, такива, че остатъкът им от деленето на 5 да е 0. Пример: в интервала (17, 25) има 2 такива числа.

using System;


namespace Zad._5
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете I-во число: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write(" Въведете II-ро число: ");
            int n2 = int.Parse(Console.ReadLine());

            int br = 0;

              for (int i = n1; i <= n2; i++)
              {
                if (i % 5 == 0)
                   br++;
              }

            Console.WriteLine(" Намерени числа в интервала: {0}", br);

        }
    }
}

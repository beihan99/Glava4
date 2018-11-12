
// Напишете програма, която прочита цяло число n от конзолата и отпечатва на конзолата всички числа в интервала [1…n], всяко на отделен ред.

using System;


namespace Zad._11
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n = int.Parse(Console.ReadLine());

              for (int i = 1; i <= n; i++)
              {
                Console.WriteLine(" {0}",i);
              }
        }
    }
}

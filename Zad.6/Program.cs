
// Напишете програма, която чете две числа от конзолата и отпечатва по-голямото от тях. Решете задачата без да използвате условни конструкции.

using System;

namespace Zad._6
{
    class Program
    {
        static void Main()
        {
            Console.Write(" I-во число = ");
            double n1 = double.Parse(Console.ReadLine());

            Console.Write(" II-ро число = ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine(" По-голямото число е {0}", Math.Max(n1,n2));
        }
    }
}

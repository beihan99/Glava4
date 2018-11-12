
// Напишете програма, която чете от конзолата три числа от тип int и отпечатва тяхната сума.

using System;


namespace Zad._1
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете I-во число: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write(" Въведете II-ро число: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write(" Въведете III-то число: ");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Сумата на числата е {0}", n1 + n2 + n3);
        }
    }
}

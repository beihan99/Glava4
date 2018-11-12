
// Напишете програма, която чете пет числа от конзолата и отпечатва най-голямото от тях

using System;


namespace Zad._8
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

            Console.Write(" Въведете IV-то число: ");
            int n4 = int.Parse(Console.ReadLine());

            Console.Write(" Въведете V-то число: ");
            int n5 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Най-голямото число е {0}",Math.Max(Math.Max(Math.Max(n1,n2), Math.Max(n3,n4)),n5));
        }
    }
}

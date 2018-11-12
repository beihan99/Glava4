
// Напишете програма, която прочита едно цяло число n от конзолата. След това прочита още nна брой числа от конзолата и отпечатва тяхната сума.

using System;

namespace Zad._10
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write(" Kолко още числа ще въведете: ");
            int br = int.Parse(Console.ReadLine());
            int sum = 0;

             for(int i=0; i < br; i++)
             {
                Console.Write(" Въведете число: ");
                int n2 = int.Parse(Console.ReadLine());
                sum += n2;
             }
            Console.WriteLine(" Сумата на числата е {0}", sum+n1);
        }
    }
}

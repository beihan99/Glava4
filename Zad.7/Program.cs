
// Напишете програма, която чете пет числа и отпечатва тяхната сума. При невалидно въведено число да се подкани потребителя да въведе друго число.

using System;


namespace Zad._7
{
    class Program
    {
        static void Main()
        {
            int n;
            int sum = 0;

              for (int i = 1; i <= 5; i++)
                {
                   string input;
                do
                {
                    Console.Write(" Въведете число: ");
                    input = Console.ReadLine();
                }
                while (!int.TryParse(input, out n));


               sum += n;
                }
            Console.WriteLine(" Сумата на числата е {0}",sum);
        }
    }
}

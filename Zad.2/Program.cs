
// Напишете програма, която чете от конзолата радиуса "r" на кръг и отпечатва неговия периметър и обиколка.

using System;

namespace Zad._2
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете радиус: ");
            int r = int.Parse(Console.ReadLine());
          
            Console.WriteLine(" Обиколката на кръга е {0:F2} см.", (2*Math.PI)*r);
            Console.WriteLine(" Лицето на кръга е {0:F2} кв.см.", Math.PI* Math.Pow(r,2));

        }
    }
}

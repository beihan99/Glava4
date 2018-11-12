
// .Напишете програма, която отпечатва на конзолата първите 100 числа от редицата на Фибоначи: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, ...

using System;


namespace Zad._12
{
    class Program
    {
        static void Main()
        {
            int n1 = 0;
            int n2 = 1;
            int sum = 1;
            int br = 0;

            Console.WriteLine(" Числова редица на Фибоначи !!!");
            Console.WriteLine("");
            Console.WriteLine("   {0}", n1);

               while (br < 100)
               {
                 sum = n1 + n2;
                 n1 = n2;
                 n2 = sum;
                 Console.WriteLine("   {0}", n2);
                 br++;
               }
        }
    }
}

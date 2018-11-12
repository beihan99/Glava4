
// Напишете програма, която отпечатва три числа в три виртуални колони на конзолата. Всяка колона трябва да е с широчина 10 символа, а числата трябва да са ляво подравнени. Първото число трябва да е цяло число в шестнадесетична бройна система, второто да е дробно положи­телно, а третото – да е дробно отрицателно. Последните две числа да се закръглят до втория знак след десетичната запетая.

using System;


namespace Zad._4
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете I-во число: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write(" Въведете II-ро число: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.Write(" Въведете III-то число: ");
            double n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("{0,-10:X}{1,-10:F2}{2,-10:F2}",n1,n2,-n3);

        }
    }
}


// Дадена фирма има име, адрес, телефонен номер, факс номер, уеб сайт и мениджър. Мениджърът има име, фамилия и телефонен номер. Напишете програма, която чете информацията за фирмата и нейния мениджър и я отпечатва след това на конзолата.

using System;


namespace Zad._3
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Име на Фирма: ");
            string Fname = Console.ReadLine();

            Console.Write(" Aдрес на Фирма: ");
            string Aname = Console.ReadLine();

            Console.Write(" Телефон: ");
            int tel = int.Parse(Console.ReadLine());

            Console.Write(" Факс: ");
            int faks = int.Parse(Console.ReadLine());

            Console.Write(" Уебсайт: ");
            string Wname = Console.ReadLine();

            Console.WriteLine("");

            Console.Write(" Име на Мениджърът: ");
            string Mname = Console.ReadLine();

            Console.Write(" Фамилия на Мениджърът: ");
            string Mfname = Console.ReadLine();

            Console.Write(" Телефон на Мениджърът: ");
            int Mtel = int.Parse(Console.ReadLine());
        }
    }
}

using System;
using System.Runtime.Versioning;
using System.Text;

namespace Part1
{
    internal class Program
    {
        static void Task1()
        {
            short day = 0;
            while (true)
            {
                Console.Write("Введите число: ");
                day = short.Parse(Console.ReadLine());
                if (day <= 365 && day > 0)
                    break;
                else
                    Console.Clear();
            }
            DateTime date = new DateTime(1, 1, 1);
            for (int i = 1; i < 366; i++)
            {
                Console.WriteLine($"Число {i} соответствует: {date.AddDays(i - 1).ToString("d MMMM")}");
            }
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Task1();

            Console.ReadKey();
        }
    }
}

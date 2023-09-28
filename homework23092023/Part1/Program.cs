using System;
using System.Text;

namespace Part1
{
    internal class Program
    {
        enum Months
        {
            Января,
            Февраля,
            Марта,
            Апреля,
            Мая,
            Июня,
            Июля,
            Августа,
            Сентября,
            Октября,
            Ноября,
            Декабря
        }
        static void Task1()
        {
            Console.WriteLine("Задание №1\nСчитать с экрана число от 1 до 365 и перевести его в месяц и день месяца");
            try
            {
                Console.Write("Введите число: ");
                short day = Convert.ToInt16(Console.ReadLine());
                DateTime date = new DateTime(1, 1, 1).AddDays(day - 1);
                Console.WriteLine($"Дата: {date.Day} {(Months)(date.Month-1)}\n");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Введено не число или нецелое число!\n");
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Введённое число не принадлежит интервалу [1;365]!\n"); ;
            }
        }
        static void Task2()
        {
            Console.WriteLine("Задание №2\nСчитать с экрана число от 1 до 365 и перевести его в месяц и день месяца, а также обработать исключение,\n в случае если число меньше 1 или больше 365");
            try
            {
                Console.Write("Введите число: ");
                short day = Convert.ToInt16(Console.ReadLine());
                DateTime date = new DateTime(2023, 1, 1).AddDays(day - 1);
                if (day < 1 || day > 365)
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                Console.WriteLine($"Дата: {date.Day} {(Months)(date.Month - 1)}\n");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Введено не число или нецелое число!\n");
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Введённое число не принадлежит интервалу [1;365]!\n");
            }
        }
        static void Task3()
        {
            Console.WriteLine("Задание №3\nСчитать с экрана число от 1 до 365 и перевести его в месяц и день месяца, а также обработать исключение,\n в случае если число меньше 1 или больше 365, а также считать год с экрана и учитывать его високосность в вычислениях");
            try
            {
                Console.Write("Введите число: ");
                short day = Convert.ToInt16(Console.ReadLine());
                Console.Write("Введите год: ");
                ushort year = Convert.ToUInt16(Console.ReadLine());
                DateTime date = new DateTime(year, 1, 1).AddDays(day - 1);
                if (day < 1 || day > 365 && !DateTime.IsLeapYear(year))
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                Console.WriteLine($"Дата: {date.Day} {(Months)(date.Month - 1)}\n");
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Введено не число или нецелое число!\n");
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Введённое число не принадлежит интервалу [1;365]!\n");
            }

        }
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Task1();
            Task2();
            Task3();

            Console.ReadKey();
        }
    }
}
using System;
using System.Text;

namespace Part1
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Задание №1\nСчитать с экрана число от 1 до 365 и перевести его в месяц и день месяца");
            try
            {
                Console.Write("Введите число: ");
                ushort day = Convert.ToUInt16(Console.ReadLine());
                DateTime date = new DateTime(1, 1, 1).AddDays(day - 1);
                switch (date.Month)
                {
                    case 1:
                        Console.WriteLine($"Дата: {date.Day} января\n");
                        break;
                    case 2:
                        Console.WriteLine($"Дата: {date.Day} февраля\n");
                        break;
                    case 3:
                        Console.WriteLine($"Дата: {date.Day} марта\n");
                        break;
                    case 4:
                        Console.WriteLine($"Дата: {date.Day} апреля\n");
                        break;
                    case 5:
                        Console.WriteLine($"Дата: {date.Day} мая\n");
                        break;
                    case 6:
                        Console.WriteLine($"Дата: {date.Day} июня\n");
                        break;
                    case 7:
                        Console.WriteLine($"Дата: {date.Day} июля\n");
                        break;
                    case 8:
                        Console.WriteLine($"Дата: {date.Day} августа\n");
                        break;
                    case 9:
                        Console.WriteLine($"Дата: {date.Day} сентября\n");
                        break;
                    case 10:
                        Console.WriteLine($"Дата: {date.Day} октября\n");
                        break;
                    case 11:
                        Console.WriteLine($"Дата: {date.Day} ноября\n");
                        break;
                    case 12:
                        Console.WriteLine($"Дата: {date.Day} декабря");
                        break;
                }
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
            Console.WriteLine("Задание №2\nСчитать с экрана число от 1 до 365 и перевести его в месяц и день месяца, а также обработать исключение, в случае если число меньше 1 или больше 365");
            try
            {
                Console.Write("Введите число: ");
                ushort day = Convert.ToUInt16(Console.ReadLine());
                DateTime date = new DateTime(2023, 1, 1).AddDays(day - 1);
                if (day < 1 || day > 365)
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                switch (date.Month)
                {
                    case 1:
                        Console.WriteLine($"Дата: {date.Day} января\n");
                        break;
                    case 2:
                        Console.WriteLine($"Дата: {date.Day} февраля\n");
                        break;
                    case 3:
                        Console.WriteLine($"Дата: {date.Day} марта\n");
                        break;
                    case 4:
                        Console.WriteLine($"Дата: {date.Day} апреля\n");
                        break;
                    case 5:
                        Console.WriteLine($"Дата: {date.Day} мая\n");
                        break;
                    case 6:
                        Console.WriteLine($"Дата: {date.Day} июня\n");
                        break;
                    case 7:
                        Console.WriteLine($"Дата: {date.Day} июля\n");
                        break;
                    case 8:
                        Console.WriteLine($"Дата: {date.Day} августа\n");
                        break;
                    case 9:
                        Console.WriteLine($"Дата: {date.Day} сентября\n");
                        break;
                    case 10:
                        Console.WriteLine($"Дата: {date.Day} октября\n");
                        break;
                    case 11:
                        Console.WriteLine($"Дата: {date.Day} ноября\n");
                        break;
                    case 12:
                        Console.WriteLine($"Дата: {date.Day} декабря");
                        break;
                }
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
            Console.WriteLine("Задание №3\nть с экрана число от 1 до 365 и перевести его в месяц и день месяца, а также обработать исключение, в случае если число меньше 1 или больше 365, а также считать год с экрана и учитывать его високосность в вычислениях");
            try
            {
                Console.Write("Введите число: ");
                ushort day = Convert.ToUInt16(Console.ReadLine());
                Console.Write("Введите год: ");
                ushort year = Convert.ToUInt16(Console.ReadLine());
                DateTime date = new DateTime(year, 1, 1).AddDays(day - 1);
                if (day < 1 || day > 365 && !DateTime.IsLeapYear(year))
                {
                    throw new System.ArgumentOutOfRangeException();
                }
                switch (date.Month)
                {
                    case 1:
                        Console.WriteLine($"Дата: {date.Day} января\n");
                        break;
                    case 2:
                        Console.WriteLine($"Дата: {date.Day} февраля\n");
                        break;
                    case 3:
                        Console.WriteLine($"Дата: {date.Day} марта\n");
                        break;
                    case 4:
                        Console.WriteLine($"Дата: {date.Day} апреля\n");
                        break;
                    case 5:
                        Console.WriteLine($"Дата: {date.Day} мая\n");
                        break;
                    case 6:
                        Console.WriteLine($"Дата: {date.Day} июня\n");
                        break;
                    case 7:
                        Console.WriteLine($"Дата: {date.Day} июля\n");
                        break;
                    case 8:
                        Console.WriteLine($"Дата: {date.Day} августа\n");
                        break;
                    case 9:
                        Console.WriteLine($"Дата: {date.Day} сентября\n");
                        break;
                    case 10:
                        Console.WriteLine($"Дата: {date.Day} октября\n");
                        break;
                    case 11:
                        Console.WriteLine($"Дата: {date.Day} ноября\n");
                        break;
                    case 12:
                        Console.WriteLine($"Дата: {date.Day} декабря");
                        break;
                }
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
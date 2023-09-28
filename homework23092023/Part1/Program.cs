using System;
using System.Text;

namespace Part1
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("Задание №1\nНеобходимо ввести число в интервале [1,365] и вывести соответствующую ему дату (день и месяц)");
            try
            {
                Console.Write("Введите число: ");
                int day = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine("Введено число, не принадлежащее интервалу [1,365]!\n");
            }
        }
        static void Task2()
        {
            Console.WriteLine("Задание №2\nНеобходимо ввести число в интервале [1,365] и вывести соответствующую ему дату (день и месяц),\nесли число меньше 1 или больше 365, программа должна вырабатывать исключение");
            try
            {
                Console.Write("Введите число: ");
                int day = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine("Введено число, не принадлежащее интервалу [1,365]!\n");
            }
        }
        static void Task3()
        {
            Console.WriteLine("Задание №2\nНеобходимо ввести число в интервале [1,365] и вывести соответствующую ему дату (день и месяц),\nесли число меньше 1 или больше 365, программа должна вырабатывать исключение");
            try
            {
                Console.Write("Введите число: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите год: ");
                int year = Convert.ToInt32(Console.ReadLine());
                DateTime date = new DateTime(year, 1, 1).AddDays(day - 1);
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
                Console.WriteLine("Введено число, не принадлежащее интервалу [1,365]!\n");
            }
        }
        static void Main(string[] args)
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

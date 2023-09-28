using System;
using System.Text;

namespace Part2
{
    internal class Program
    {
        enum Cards
        {
            Шестёрка = 6,
            Семёрка = 7,
            Восьмёрка = 8,
            Девятка = 9,
            Десятка = 10,
            Валет = 11,
            Дама = 12,
            Король = 13,
            Туз = 14
        }
        enum WeekDays
        {
            понедельник = 1,
            вторник = 2,
            среда = 3,
            четверг = 4,
            пятница = 5,
            суббота = 6,
            воскресенье = 7
        }
        static void Task1()
        {
            Console.WriteLine("Задание №1\nОпределить является ли последовательность упорядоченной по возрастанию, если нет - вывести\n порядковый номер первого числа, нарушающего её возрастание");
            int[] numbers = new int[10];
            Random random = new Random();
            bool isGrowing = true;
            Console.Write("Последовательность: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100);
                Console.Write(numbers[i] + " ");
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    Console.WriteLine($"\nПоследовательность не является возрастающей, её нарушает число №{i+2}\n");
                    isGrowing = false;
                    break;
                }
            }
            if (isGrowing)
            {
                Console.WriteLine("\nПоследовательность является возрастающей\n");
            }
        }
        static void Task2()
        {
            Console.WriteLine("Задание №2\nСчитать номер карты с экрана и вывести её название");
            Console.Write("Введите число: ");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Карта соответствующая числу {number} - {(Cards)number}\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено не число или нецелое число!\n");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Введённое число не принадлежит интервалу [6;14]");
            }
        }
        static void Task3()

        {
            Console.WriteLine("Задание №3\nСчитать прозвище с экрана и вывести соответствующую ему выпивку");
            Console.Write("Введите строку: ");
            string nickname = Console.ReadLine();
            nickname = nickname.ToLower();
            switch (nickname)
            {
                case "jabroni":
                    Console.WriteLine("Parton Tequila\n");
                    break;
                case "school counselor":
                    Console.WriteLine("Anything with Alcohol\n");
                    break;
                case "programmer":
                    Console.WriteLine("Hipster Craft Beer\n");
                    break;
                case "bike gang member":
                    Console.WriteLine("Moonshine\n");
                    break;
                case "politician":
                    Console.WriteLine("Your tax dollars\n");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal\n");
                    break;
                default:
                    Console.WriteLine("Beer\n");
                    break;
            }
        }
        static void Task4()
        {
            Console.WriteLine("Задание №4\nСчитать число с экрана и вывести соответствующий ему день недели на экран");
            try
            {
                Console.Write("Введите число: ");
                int day = Convert.ToInt32(Console.ReadLine());
                if (1 <= day && day <= 7)
                {
                    Console.WriteLine($"Числу {day} соответствует {(WeekDays)day}\n");
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException();
                }
            }
            catch (System.FormatException) 
            {
                Console.WriteLine("Введено не число или нецелое число!\n");
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Введено число не являющееся целым или не принадлежащее отрезку от 1 до 7!\n");
            }
        }
        static void Task5()
        {
            Console.WriteLine("Задание №5\nСоздать массив строк, пройтись по нему, при встрече элементов \"Hello Kitty\" или \"Barbie doll\" увеличивать счётчик\n и вывести количество таких строк");
            uint answer = 0;
            string[] array = {"Hello Kitty", "Barbie doll", "bArBiE dOlL", "hElLo KiTtY", "cat", "dog", "pig", "cow"};
            foreach (string str in array)
            {
                if (str.ToLower() == "hello kitty" || str.ToLower() == "barbie doll")
                {
                    answer++;
                }
            }
            Console.WriteLine($"Кукол в сумке: {answer}");
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Task1();
            Task2();
            Task3();
            Task4();
            Task5();

            Console.ReadKey();
        }
    }
}

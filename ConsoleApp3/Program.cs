using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер таблицы умножения:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Таблица умножения {number}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} x {i} = {number * i}");
            }

            Console.ReadLine();
        }
    }
}

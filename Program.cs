using System;

namespace Lab8ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Число {num} в квадрате = {num * num}");
        }
    }
}
